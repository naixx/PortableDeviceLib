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

        public IEnumerable<PortableDeviceObject> Find(string path)
        {
            var list = new List<PortableDeviceObject>();
            
            // Here, we skip actual service functional objects
            foreach (var storage in storages)
            {
                var actualPath = new Queue<string>(path.Split(new[] {'/'}, StringSplitOptions.RemoveEmptyEntries));
                list.AddRange(FindInternal(actualPath, storage.Childs));
            }

            return list;
        }

        private static IEnumerable<PortableDeviceObject> FindInternal(Queue<string> paths, IEnumerable<PortableDeviceObject> objectCollection)
        {
            var res = new List<PortableDeviceObject>();
            if (paths.Count == 0)
                return res;

            string pathNode = paths.Dequeue();
            
            foreach (var deviceObject in objectCollection.Where(deviceObject => MatchesPath(deviceObject, pathNode)))
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
            return Regex.IsMatch(portableDeviceObject.Name, pathNode, RegexOptions.IgnoreCase);
        }

        /// <summary>
        ///     Transfer from device to computer
        ///     Source : http://cgeers.com/2011/08/13/wpd-transferring-content/
        ///     Inspired by nikon-camera-control
        /// </summary>
        /// <param name="deviceObject"></param>
        /// <param name="targetStream"></param>
        public void TransferFromDevice(PortableDeviceObject deviceObject, Stream targetStream)
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
            do
            {
                try
                {
                    resources.GetStream(deviceObject.ID, ref property, 0, ref optimalTransferSize, out wpdStream);
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
                    targetStream.Write(buffer, 0, bytesRead);
                } while (bytesRead > 0);

                targetStream.Close();
            }
            Marshal.ReleaseComObject(sourceStream);
            Marshal.ReleaseComObject(wpdStream);
        }

        private IEnumerable<PortableDeviceFunctionalObject> ExtractStorageServices()
        {
            return from fo in device.Content.Childs.OfType<PortableDeviceFunctionalObject>()
                   where fo.Category == PortableDeviceGuids.WPD_FUNCTIONAL_CATEGORY_STORAGE
                   select fo;
        }
    }
}