using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using PortableDeviceApiLib;
using PortableDeviceLib.Model;
using PortableDeviceTypesLib;
using IPortableDeviceValues = PortableDeviceApiLib.IPortableDeviceValues;
using IStream = PortableDeviceApiLib.IStream;
using _tagpropertykey = PortableDeviceApiLib._tagpropertykey;

namespace PortableDeviceLib
{
    public class StorageServicesAdapter
    {
        private readonly PortableDevice device;
        private readonly PortableDeviceClass portableDeviceClass;
        private readonly ObservableCollection<PortableDeviceFunctionalObject> storages;

        public StorageServicesAdapter(PortableDevice device)
        {
            this.device = device;
            portableDeviceClass = device.PortableDeviceClass;
            storages = new ObservableCollection<PortableDeviceFunctionalObject>(ExtractStorageServices());
            Storages = new ReadOnlyObservableCollection<PortableDeviceFunctionalObject>(storages);
        }

        public ReadOnlyObservableCollection<PortableDeviceFunctionalObject> Storages { get; set; }

        /// <summary>
        ///     Finds collection of specified objects in <b>each</b> storage service of WPD device
        ///     /android/music/mp3
        ///     /.*/.*/mp3
        ///     /android/sic
        /// </summary>
        /// <param name="path">Represents a '/' delimeted path; each node can be RegEx pattern, not wildcard pattern; </param>
        /// <returns></returns>
        public IEnumerable<PortableDeviceObject> Find(string path)
        {
            var list = new List<PortableDeviceObject>();

            // Here, we skip actual service functional objects
            foreach (PortableDeviceFunctionalObject storage in storages)
            {
                list.AddRange(Find(path, storage));
            }

            return list;
        }

        /// <summary>
        ///     Finds collection of specified objects in specific storage service of WPD device
        ///     /android/music/mp3
        ///     /.*/.*/mp3
        ///     /android/sic
        /// </summary>
        /// <param name="path">Represents a '/' delimeted path; each node can be RegEx pattern, not wildcard pattern; </param>
        /// <param name="storage"></param>
        /// <returns></returns>
        public IEnumerable<PortableDeviceObject> Find(string path, PortableDeviceContainerObject parent)
        {
            var actualPath = new Queue<string>(path.Split(new[] {'/'}, StringSplitOptions.RemoveEmptyEntries));
            return FindInternal(actualPath, parent.Childs);
        }

        public bool Exists(string path)
        {
            return Find(path).Any();
        }

        public bool Exists(string path, PortableDeviceFunctionalObject storage)
        {
            return Find(path, storage).Any();
        }

        /// <summary>
        ///     Transfer from device to computer
        ///     Source : http://cgeers.com/2011/08/13/wpd-transferring-content/
        ///     Inspired by nikon-camera-control
        /// </summary>
        /// <param name="deviceObject"></param>
        /// <param name="targetStream"></param>
        public void Pull(PortableDeviceObject deviceObject, Stream targetStream)
        {
            IPortableDeviceContent content;
            portableDeviceClass.Content(out content);
            IPortableDeviceResources resources;
            content.Transfer(out resources);

            IStream wpdStream;
            uint optimalTransferSize = 0;

            _tagpropertykey property = PortableDevicePKeys.WPD_RESOURCE_DEFAULT;

            int numRetries = 3;
            const int retryTimeout = 500;
            const uint STGM_READ = 0;
            do
            {
                try
                {
                    resources.GetStream(deviceObject.ID, ref property, STGM_READ, ref optimalTransferSize, out wpdStream);
                    numRetries = 0;
                }
                catch (COMException comException)
                {
                    if ((uint) comException.ErrorCode == PortableDeviceErrorCodes.ERROR_BUSY)
                    {
                        Thread.Sleep(retryTimeout);
                    }
                    throw;
                }
            } while (numRetries-- > 0);

            var sourceStream = (System.Runtime.InteropServices.ComTypes.IStream) wpdStream;
            unsafe
            {
                var buffer = new byte[1024*256];
                int bytesRead;
                do
                {
                    sourceStream.Read(buffer, buffer.Length, new IntPtr(&bytesRead));
                    if (bytesRead == 0)
                        break;
                    targetStream.Write(buffer, 0, bytesRead);
                } while (bytesRead > 0);

                targetStream.Close();
            }
            Marshal.ReleaseComObject(sourceStream);
            Marshal.ReleaseComObject(wpdStream);
        }

        public PortableDeviceObject Push(PortableDeviceContainerObject parentObject, Stream sourceStream, string originalFileName, ulong size)
        {
            return Push(parentObject, sourceStream, originalFileName, originalFileName, size);
        }

        /// <summary>
        ///     Inspired by http://cgeers.com/2012/04/17/wpd-transfer-content-to-a-device/
        /// </summary>
        /// <param name="parentObject"></param>
        /// <param name="sourceStream"></param>
        /// <param name="name"></param>
        /// <param name="originalFileName"></param>
        /// <param name="size"></param>
        public PortableDeviceObject Push(PortableDeviceContainerObject parentObject, Stream sourceStream, string name, string originalFileName, ulong size)
        {
            IPortableDeviceContent content;
            portableDeviceClass.Content(out content);
            IPortableDeviceValues values = GetRequiredPropertiesForPush(parentObject, name, originalFileName, size);

            IStream tempStream;
            uint optimalTransferSizeBytes = 0;
            content.CreateObjectWithPropertiesAndData(values, out tempStream, ref optimalTransferSizeBytes, null);

            var targetStream = (System.Runtime.InteropServices.ComTypes.IStream) tempStream;

            try
            {
                var buffer = new byte[optimalTransferSizeBytes];
                int bytesRead;
                do
                {
                    bytesRead = sourceStream.Read(buffer, 0, (int) optimalTransferSizeBytes);
                    IntPtr pcbWritten = IntPtr.Zero;

                    if (bytesRead < (int) optimalTransferSizeBytes)
                        targetStream.Write(buffer, bytesRead, pcbWritten);
                    else
                        targetStream.Write(buffer, (int) optimalTransferSizeBytes, pcbWritten);
                } while (bytesRead > 0);

                targetStream.Commit(0);

                device.Enumerate(ref content, parentObject.ID, parentObject, detectNewObjects: true);

                // TODO There is no IPortableDeviceDataStream in C# port to get ID, so we will make a bicycle
                return Find("^" + originalFileName + "$", parentObject).First();
            }
            finally
            {
                Marshal.ReleaseComObject(tempStream);
            }
        }

        public PortableDeviceObject Mkdir(PortableDeviceContainerObject parentObject, string name)
        {
            IPortableDeviceContent content;
            portableDeviceClass.Content(out content);

            var values = (IPortableDeviceValues) new PortableDeviceValues();
            values.SetStringValue(PortableDevicePKeys.WPD_OBJECT_PARENT_ID, parentObject.ID);
            values.SetStringValue(PortableDevicePKeys.WPD_OBJECT_ORIGINAL_FILE_NAME, name);
            values.SetGuidValue(PortableDevicePKeys.WPD_OBJECT_CONTENT_TYPE, PortableDeviceGuids.WPD_CONTENT_TYPE_FOLDER);
            string objId = String.Empty;
            content.CreateObjectWithPropertiesOnly(values, ref objId);

            device.Enumerate(ref content, parentObject.ID, parentObject, detectNewObjects: true);

            var q = from obj in parentObject.Childs
                    where obj.ID == objId
                    select obj;

            return q.First();
        }

        #region private

        private IPortableDeviceValues GetRequiredPropertiesForPush(PortableDeviceObject parentObject, string name, string originalFileName, ulong size)
        {
            var values = (IPortableDeviceValues) new PortableDeviceValues();
            values.SetStringValue(PortableDevicePKeys.WPD_OBJECT_PARENT_ID, parentObject.ID);
            values.SetUnsignedLargeIntegerValue(PortableDevicePKeys.WPD_OBJECT_SIZE, size);
            values.SetStringValue(PortableDevicePKeys.WPD_OBJECT_ORIGINAL_FILE_NAME, originalFileName);
            values.SetStringValue(PortableDevicePKeys.WPD_OBJECT_NAME, name);
            return values;
        }

        private static IEnumerable<PortableDeviceObject> FindInternal(Queue<string> paths, IEnumerable<PortableDeviceObject> objectCollection)
        {
            var res = new List<PortableDeviceObject>();
            if (paths.Count == 0)
                return res;

            string pathNode = paths.Dequeue();

            foreach (PortableDeviceObject deviceObject in objectCollection.Where(deviceObject => MatchesPath(deviceObject, pathNode)))
            {
                if (paths.Count == 0)
                {
                    res.Add(deviceObject);
                }
                else
                {
                    var folder = deviceObject as PortableDeviceContainerObject;
                    if (folder != null)
                        res.AddRange(FindInternal(new Queue<string>(paths), folder.Childs));
                }
            }

            return res;
        }

        private static bool MatchesPath(PortableDeviceObject portableDeviceObject, string pathNode)
        {
            // Defined content types that represent filesystem object don't contain extension
            var file = portableDeviceObject as PortableDeviceFileObject;
            if (file != null)
                return Regex.IsMatch(file.FileName, pathNode, RegexOptions.IgnoreCase);
            return Regex.IsMatch(portableDeviceObject.Name, pathNode, RegexOptions.IgnoreCase);
        }

        private IEnumerable<PortableDeviceFunctionalObject> ExtractStorageServices()
        {
            return from fo in device.Content.Childs.OfType<PortableDeviceFunctionalObject>()
                   where fo.Category == PortableDeviceGuids.WPD_FUNCTIONAL_CATEGORY_STORAGE
                   select fo;
        }

        #endregion
    }
}