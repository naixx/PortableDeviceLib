#region License

/*
PortableDeviceHelpers.cs
Copyright (C) 2009 Vincent Lainé
 
This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using PortableDeviceTypesLib;
using IPortableDeviceValues = PortableDeviceApiLib.IPortableDeviceValues;
using _tagpropertykey = PortableDeviceApiLib._tagpropertykey;
using tag_inner_PROPVARIANT = PortableDeviceApiLib.tag_inner_PROPVARIANT;

namespace PortableDeviceLib
{
    // Nested Types
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct PropVariant
    {
        [FieldOffset(0)]
        public short variantType;
        [FieldOffset(8)]
        public IntPtr pointerValue;
        [FieldOffset(8)]
        public byte byteValue;
        [FieldOffset(8)]
        public long longValue;
        [FieldOffset(8)]
        public double dateValue;
        [FieldOffset(8)]
        public short boolValue;
    }


    internal static class PortableDeviceHelpers
    {
        public static int VT_DATE;
        public static int VT_LPWSTR;
        public static int VT_UI4;
        public static int VT_UI8;
        public static int VT_UINT;

        private static readonly Dictionary<string, _tagpropertykey> _values;
        private static readonly Dictionary<Guid, string> _portableDeviceGuidWithName;

        static PortableDeviceHelpers()
        {
            VT_LPWSTR = 0x1f;
            VT_DATE = 7;
            VT_UI4 = 0x13;
            VT_UINT = 0x17;
            VT_UI8 = 0x15;

            _values = new Dictionary<string, _tagpropertykey>
                {
                    {MTPConstants.OBJECT_PLAY_COUNT, PortableDevicePKeys.WPD_MEDIA_USE_COUNT},
                    {MTPConstants.OBJECT_GENRE, PortableDevicePKeys.WPD_MEDIA_GENRE},
                    {MTPConstants.OBJECT_STAR_RATING, PortableDevicePKeys.WPD_MEDIA_STAR_RATING},
                    {MTPConstants.OBJECT_ARTIST, PortableDevicePKeys.WPD_MEDIA_ARTIST},
                    {MTPConstants.OBJECT_ALBUM_ARTIST, PortableDevicePKeys.WPD_MEDIA_ALBUM_ARTIST},
                    {MTPConstants.OBJECT_SUBSCRIPTION_CONTENT_ID, PortableDevicePKeys.WPD_MEDIA_SUBSCRIPTION_CONTENT_ID},
                    {MTPConstants.OBJECT_EFFECTIVE_RATING, PortableDevicePKeys.WPD_MEDIA_USER_EFFECTIVE_RATING},
                    {MTPConstants.OBJECT_ALBUM, PortableDevicePKeys.WPD_MUSIC_ALBUM},
                    {MTPConstants.OBJECT_TRACK, PortableDevicePKeys.WPD_MUSIC_TRACK},
                    {MTPConstants.OBJECT_ID, PortableDevicePKeys.WPD_OBJECT_ID},
                    {MTPConstants.OBJECT_SIZE, PortableDevicePKeys.WPD_OBJECT_SIZE},
                    {MTPConstants.OBJECT_DURATION, PortableDevicePKeys.WPD_MEDIA_DURATION},
                    {MTPConstants.OBJECT_TITLE, PortableDevicePKeys.WPD_MEDIA_TITLE},
                    {MTPConstants.OBJECT_DATE_AUTHORED, PortableDevicePKeys.WPD_OBJECT_DATE_AUTHORED},
                    {MTPConstants.OBJECT_DATE_CREATED, PortableDevicePKeys.WPD_OBJECT_DATE_CREATED},
                    {MTPConstants.OBJECT_MODIFIED, PortableDevicePKeys.WPD_OBJECT_DATE_MODIFIED},
                    {MTPConstants.OBJECT_FORMAT, PortableDevicePKeys.WPD_OBJECT_FORMAT},
                    {MTPConstants.OBJECT_DRM_PROTECTED, PortableDevicePKeys.WPD_OBJECT_IS_DRM_PROTECTED},
                    {MTPConstants.OBJECT_FILENAME, PortableDevicePKeys.WPD_OBJECT_ORIGINAL_FILE_NAME},
                    {MTPConstants.OBJECT_NAME, PortableDevicePKeys.WPD_OBJECT_NAME},
                    {MTPConstants.OBJECT_PERSISTENT_ID, PortableDevicePKeys.WPD_OBJECT_PERSISTENT_UNIQUE_ID},
                    {MTPConstants.OBJECT_TOTAL_BITRATE, PortableDevicePKeys.WPD_MEDIA_TOTAL_BITRATE},
                    {MTPConstants.OBJECT_SKIP_COUNT, PortableDevicePKeys.WPD_MEDIA_SKIP_COUNT},
                    {MTPConstants.OBJECT_SAMPLE_RATE, PortableDevicePKeys.WPD_MEDIA_SAMPLE_RATE},
                    {MTPConstants.OBJECT_RELEASE_DATE, PortableDevicePKeys.WPD_MEDIA_RELEASE_DATE},
                    {MTPConstants.OBJECT_LAST_BUILD_DATE, PortableDevicePKeys.WPD_MEDIA_LAST_BUILD_DATE},
                    {MTPConstants.OBJECT_LAST_ACCESSED_TIME, PortableDevicePKeys.WPD_MEDIA_LAST_ACCESSED_TIME},
                    {MTPConstants.OBJECT_BITRATE_TYPE, PortableDevicePKeys.WPD_MEDIA_BITRATE_TYPE},
                    {MTPConstants.OBJECT_ALBUM_ART, PortableDevicePKeys.WPD_RESOURCE_ALBUM_ART},
                    {MTPConstants.DEVICE_FIRMWARE_VERSION, PortableDevicePKeys.WPD_DEVICE_FIRMWARE_VERSION},
                    {MTPConstants.DEVICE_FRIENDLY_NAME, PortableDevicePKeys.WPD_DEVICE_FRIENDLY_NAME},
                    {MTPConstants.DEVICE_MANUFACTURER, PortableDevicePKeys.WPD_DEVICE_MANUFACTURER},
                    {MTPConstants.DEVICE_MODEL, PortableDevicePKeys.WPD_DEVICE_MODEL},
                    {MTPConstants.DEVICE_BATTERY_LEVEL, PortableDevicePKeys.WPD_DEVICE_POWER_LEVEL},
                    {MTPConstants.DEVICE_POWER_SOURCE, PortableDevicePKeys.WPD_DEVICE_POWER_SOURCE},
                    {MTPConstants.DEVICE_SERIAL_NUMBER, PortableDevicePKeys.WPD_DEVICE_SERIAL_NUMBER},
                    {MTPConstants.OBJECT_CONTENT_TYPE, PortableDevicePKeys.WPD_OBJECT_CONTENT_TYPE}
                };

            _portableDeviceGuidWithName = MakeGlobalDictionary();
        }

        public static Dictionary<Guid, string> PortableDeviceGuidWithName
        {
            get { return _portableDeviceGuidWithName; }
        }

        public static string GetNameFromGuid(_tagpropertykey key, tag_inner_PROPVARIANT values)
        {
            var pValues = (IPortableDeviceValues) new PortableDeviceValuesClass();
            string contentTypeName;

            pValues.SetValue(ref key, ref values);
            pValues.GetStringValue(ref key, out contentTypeName);

            return contentTypeName;
        }

        public static string GetKeyNameFromGuid(Guid guid)
        {
            if (PortableDeviceGuidWithName.ContainsKey(guid))
                return PortableDeviceGuidWithName[guid];
            else
                return guid.ToString();
        }

        internal static string GetKeyNameFromPropkey(_tagpropertykey propertyKey)
        {
            foreach (var de in _values.Where(de => (propertyKey.pid == de.Value.pid) && (propertyKey.fmtid == de.Value.fmtid)))
            {
                return de.Key;
            }

            return (propertyKey.pid.ToString() + " " + propertyKey.fmtid.ToString());
        }

        private static Dictionary<Guid, string> MakeGlobalDictionary()
        {
            return typeof (PortableDeviceGuids).GetFields().ToDictionary(fi => (Guid) fi.GetValue(null), fi => fi.Name);
        }
    }
}