﻿#region License
/*
DevicePortablePKeys.cs
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
using System.Text;
using PortableDeviceApiLib;

namespace PortableDeviceLib
{
    /// <summary>
    /// Regroup default item from WPD
    /// </summary>
    public class PortableDevicePKeys
    {
        /// <summary>
        /// 
        /// </summary>
        static PortableDevicePKeys()
        {
            WPD_RESOURCE_DEFAULT.fmtid = new Guid(0xE81E79BE, 0x34F0, 0x41BF, 0xB5, 0x3F, 0xF1, 0xA0, 0x6A, 0xE8, 0x78, 0x42);
            WPD_RESOURCE_DEFAULT.pid = 0;

            WPD_RESOURCE_CONTACT_PHOTO.fmtid = new Guid(0x2C4D6803, 0x80EA, 0x4580, 0xAF, 0x9A, 0x5B, 0xE1, 0xA2, 0x3E, 0xDD, 0xCB);
            WPD_RESOURCE_CONTACT_PHOTO.pid = 0;

            WPD_RESOURCE_THUMBNAIL.fmtid = new Guid(0xC7C407BA, 0x98FA, 0x46B5, 0x99, 0x60, 0x23, 0xFE, 0xC1, 0x24, 0xCF, 0xDE);
            WPD_RESOURCE_THUMBNAIL.pid = 0;

            WPD_RESOURCE_ICON.fmtid = new Guid(0xF195FED8, 0xAA28, 0x4EE3, 0xB1, 0x53, 0xE1, 0x82, 0xDD, 0x5E, 0xDC, 0x39);
            WPD_RESOURCE_ICON.pid = 0;

            WPD_RESOURCE_AUDIO_CLIP.fmtid = new Guid(0x3BC13982, 0x85B1, 0x48E0, 0x95, 0xA6, 0x8D, 0x3A, 0xD0, 0x6B, 0xE1, 0x17);
            WPD_RESOURCE_AUDIO_CLIP.pid = 0;

            WPD_RESOURCE_ALBUM_ART.fmtid = new Guid(0xF02AA354, 0x2300, 0x4E2D, 0xA1, 0xB9, 0x3B, 0x67, 0x30, 0xF7, 0xFA, 0x21);
            WPD_RESOURCE_ALBUM_ART.pid = 0;

            WPD_RESOURCE_GENERIC.fmtid = new Guid(0xB9B9F515, 0xBA70, 0x4647, 0x94, 0xDC, 0xFA, 0x49, 0x25, 0xE9, 0x5A, 0x07);
            WPD_RESOURCE_GENERIC.pid = 0;

            WPD_RESOURCE_VIDEO_CLIP.fmtid = new Guid(0xB566EE42, 0x6368, 0x4290, 0x86, 0x62, 0x70, 0x18, 0x2F, 0xB7, 0x9F, 0x20);
            WPD_RESOURCE_VIDEO_CLIP.pid = 0;

            WPD_RESOURCE_BRANDING_ART.fmtid = new Guid(0xB633B1AE, 0x6CAF, 0x4A87, 0x95, 0x89, 0x22, 0xDE, 0xD6, 0xDD, 0x58, 0x99);
            WPD_RESOURCE_BRANDING_ART.pid = 0;

            WPD_PROPERTY_NULL.fmtid = new Guid(0x00000000, 0x0000, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00);
            WPD_PROPERTY_NULL.pid = 0;

            WPD_OBJECT_ID.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_ID.pid = 2;

            WPD_OBJECT_PARENT_ID.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_PARENT_ID.pid = 3;

            WPD_OBJECT_NAME.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_NAME.pid = 4;

            WPD_OBJECT_PERSISTENT_UNIQUE_ID.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_PERSISTENT_UNIQUE_ID.pid = 5;

            WPD_OBJECT_FORMAT.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_FORMAT.pid = 6;

            WPD_OBJECT_CONTENT_TYPE.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_CONTENT_TYPE.pid = 7;

            WPD_OBJECT_ISHIDDEN.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_ISHIDDEN.pid = 9;

            WPD_OBJECT_ISSYSTEM.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_ISSYSTEM.pid = 10;

            WPD_OBJECT_SIZE.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_SIZE.pid = 11;

            WPD_OBJECT_ORIGINAL_FILE_NAME.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_ORIGINAL_FILE_NAME.pid = 12;

            WPD_OBJECT_NON_CONSUMABLE.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_NON_CONSUMABLE.pid = 13;

            WPD_OBJECT_REFERENCES.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_REFERENCES.pid = 14;

            WPD_OBJECT_KEYWORDS.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_KEYWORDS.pid = 15;

            WPD_OBJECT_SYNC_ID.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_SYNC_ID.pid = 16;

            WPD_OBJECT_IS_DRM_PROTECTED.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_IS_DRM_PROTECTED.pid = 17;

            WPD_OBJECT_DATE_CREATED.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_DATE_CREATED.pid = 18;

            WPD_OBJECT_DATE_MODIFIED.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_DATE_MODIFIED.pid = 19;

            WPD_OBJECT_DATE_AUTHORED.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_DATE_AUTHORED.pid = 20;

            WPD_OBJECT_BACK_REFERENCES.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_BACK_REFERENCES.pid = 21;

            WPD_OBJECT_CONTAINER_FUNCTIONAL_OBJECT_ID.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_CONTAINER_FUNCTIONAL_OBJECT_ID.pid = 23;

            WPD_OBJECT_GENERATE_THUMBNAIL_FROM_RESOURCE.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_GENERATE_THUMBNAIL_FROM_RESOURCE.pid = 24;

            WPD_OBJECT_HINT_LOCATION_DISPLAY_NAME.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_HINT_LOCATION_DISPLAY_NAME.pid = 25;

            WPD_OBJECT_CAN_DELETE.fmtid = new Guid(0xEF6B490D, 0x5CD8, 0x437A, 0xAF, 0xFC, 0xDA, 0x8B, 0x60, 0xEE, 0x4A, 0x3C);
            WPD_OBJECT_CAN_DELETE.pid = 26;

            WPD_FUNCTIONAL_OBJECT_CATEGORY.fmtid = new Guid(0x8F052D93, 0xABCA, 0x4FC5, 0xA5, 0xAC, 0xB0, 0x1D, 0xF4, 0xDB, 0xE5, 0x98);
            WPD_FUNCTIONAL_OBJECT_CATEGORY.pid = 2;

            WPD_FOLDER_CONTENT_TYPES_ALLOWED.fmtid = new Guid(0x7E9A7ABF, 0xE568, 0x4B34, 0xAA, 0x2F, 0x13, 0xBB, 0x12, 0xAB, 0x17, 0x7D);
            WPD_FOLDER_CONTENT_TYPES_ALLOWED.pid = 2;

            WPD_IMAGE_BITDEPTH.fmtid = new Guid(0x63D64908, 0x9FA1, 0x479F, 0x85, 0xBA, 0x99, 0x52, 0x21, 0x64, 0x47, 0xDB);
            WPD_IMAGE_BITDEPTH.pid = 3;

            WPD_IMAGE_CROPPED_STATUS.fmtid = new Guid(0x63D64908, 0x9FA1, 0x479F, 0x85, 0xBA, 0x99, 0x52, 0x21, 0x64, 0x47, 0xDB);
            WPD_IMAGE_CROPPED_STATUS.pid = 4;

            WPD_IMAGE_COLOR_CORRECTED_STATUS.fmtid = new Guid(0x63D64908, 0x9FA1, 0x479F, 0x85, 0xBA, 0x99, 0x52, 0x21, 0x64, 0x47, 0xDB);
            WPD_IMAGE_COLOR_CORRECTED_STATUS.pid = 5;

            WPD_IMAGE_FNUMBER.fmtid = new Guid(0x63D64908, 0x9FA1, 0x479F, 0x85, 0xBA, 0x99, 0x52, 0x21, 0x64, 0x47, 0xDB);
            WPD_IMAGE_FNUMBER.pid = 6;

            WPD_IMAGE_EXPOSURE_TIME.fmtid = new Guid(0x63D64908, 0x9FA1, 0x479F, 0x85, 0xBA, 0x99, 0x52, 0x21, 0x64, 0x47, 0xDB);
            WPD_IMAGE_EXPOSURE_TIME.pid = 7;

            WPD_IMAGE_EXPOSURE_INDEX.fmtid = new Guid(0x63D64908, 0x9FA1, 0x479F, 0x85, 0xBA, 0x99, 0x52, 0x21, 0x64, 0x47, 0xDB);
            WPD_IMAGE_EXPOSURE_INDEX.pid = 8;

            WPD_MEDIA_TOTAL_BITRATE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_TOTAL_BITRATE.pid = 2;

            WPD_MEDIA_BITRATE_TYPE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_BITRATE_TYPE.pid = 3;

            WPD_MEDIA_COPYRIGHT.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_COPYRIGHT.pid = 4;

            WPD_MEDIA_SUBSCRIPTION_CONTENT_ID.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_SUBSCRIPTION_CONTENT_ID.pid = 5;

            WPD_MEDIA_USE_COUNT.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_USE_COUNT.pid = 6;

            WPD_MEDIA_SKIP_COUNT.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_SKIP_COUNT.pid = 7;

            WPD_MEDIA_LAST_ACCESSED_TIME.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_LAST_ACCESSED_TIME.pid = 8;

            WPD_MEDIA_PARENTAL_RATING.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_PARENTAL_RATING.pid = 9;

            WPD_MEDIA_META_GENRE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_META_GENRE.pid = 10;

            WPD_MEDIA_COMPOSER.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_COMPOSER.pid = 11;

            WPD_MEDIA_EFFECTIVE_RATING.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_EFFECTIVE_RATING.pid = 12;

            WPD_MEDIA_SUB_TITLE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_SUB_TITLE.pid = 13;

            WPD_MEDIA_RELEASE_DATE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_RELEASE_DATE.pid = 14;

            WPD_MEDIA_SAMPLE_RATE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_SAMPLE_RATE.pid = 15;

            WPD_MEDIA_STAR_RATING.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_STAR_RATING.pid = 16;

            WPD_MEDIA_USER_EFFECTIVE_RATING.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_USER_EFFECTIVE_RATING.pid = 17;

            WPD_MEDIA_TITLE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_TITLE.pid = 18;

            WPD_MEDIA_DURATION.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_DURATION.pid = 19;

            WPD_MEDIA_BUY_NOW.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_BUY_NOW.pid = 20;

            WPD_MEDIA_ENCODING_PROFILE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_ENCODING_PROFILE.pid = 21;

            WPD_MEDIA_WIDTH.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_WIDTH.pid = 22;

            WPD_MEDIA_HEIGHT.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_HEIGHT.pid = 23;

            WPD_MEDIA_ARTIST.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_ARTIST.pid = 24;

            WPD_MEDIA_ALBUM_ARTIST.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_ALBUM_ARTIST.pid = 25;

            WPD_MEDIA_OWNER.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_OWNER.pid = 26;

            WPD_MEDIA_MANAGING_EDITOR.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_MANAGING_EDITOR.pid = 27;

            WPD_MEDIA_WEBMASTER.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_WEBMASTER.pid = 28;

            WPD_MEDIA_SOURCE_URL.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_SOURCE_URL.pid = 29;

            WPD_MEDIA_DESTINATION_URL.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_DESTINATION_URL.pid = 30;

            WPD_MEDIA_DESCRIPTION.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_DESCRIPTION.pid = 31;

            WPD_MEDIA_GENRE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_GENRE.pid = 32;

            WPD_MEDIA_TIME_BOOKMARK.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_TIME_BOOKMARK.pid = 33;

            WPD_MEDIA_OBJECT_BOOKMARK.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_OBJECT_BOOKMARK.pid = 34;

            WPD_MEDIA_LAST_BUILD_DATE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_LAST_BUILD_DATE.pid = 35;

            WPD_MEDIA_BYTE_BOOKMARK.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_BYTE_BOOKMARK.pid = 36;

            WPD_MEDIA_TIME_TO_LIVE.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_TIME_TO_LIVE.pid = 37;

            WPD_MEDIA_GUID.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_GUID.pid = 38;

            WPD_MEDIA_SUB_DESCRIPTION.fmtid = new Guid(0x2ED8BA05, 0x0AD3, 0x42DC, 0xB0, 0xD0, 0xBC, 0x95, 0xAC, 0x39, 0x6A, 0xC8);
            WPD_MEDIA_SUB_DESCRIPTION.pid = 39;

            WPD_CONTACT_DISPLAY_NAME.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_DISPLAY_NAME.pid = 2;

            WPD_CONTACT_FIRST_NAME.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_FIRST_NAME.pid = 3;

            WPD_CONTACT_MIDDLE_NAMES.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_MIDDLE_NAMES.pid = 4;

            WPD_CONTACT_LAST_NAME.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_LAST_NAME.pid = 5;

            WPD_CONTACT_PREFIX.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PREFIX.pid = 6;

            WPD_CONTACT_SUFFIX.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_SUFFIX.pid = 7;

            WPD_CONTACT_PHONETIC_FIRST_NAME.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PHONETIC_FIRST_NAME.pid = 8;

            WPD_CONTACT_PHONETIC_LAST_NAME.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PHONETIC_LAST_NAME.pid = 9;

            WPD_CONTACT_PERSONAL_FULL_POSTAL_ADDRESS.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_FULL_POSTAL_ADDRESS.pid = 10;

            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE1.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE1.pid = 11;

            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE2.pid = 12;

            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_CITY.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_CITY.pid = 13;

            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_REGION.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_REGION.pid = 14;

            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_POSTAL_CODE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_POSTAL_CODE.pid = 15;

            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_COUNTRY.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_COUNTRY.pid = 16;

            WPD_CONTACT_BUSINESS_FULL_POSTAL_ADDRESS.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_FULL_POSTAL_ADDRESS.pid = 17;

            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE1.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE1.pid = 18;

            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE2.pid = 19;

            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_CITY.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_CITY.pid = 20;

            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_REGION.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_REGION.pid = 21;

            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_POSTAL_CODE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_POSTAL_CODE.pid = 22;

            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_COUNTRY.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_COUNTRY.pid = 23;

            WPD_CONTACT_OTHER_FULL_POSTAL_ADDRESS.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_FULL_POSTAL_ADDRESS.pid = 24;

            WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE1.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE1.pid = 25;

            WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE2.pid = 26;

            WPD_CONTACT_OTHER_POSTAL_ADDRESS_CITY.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_POSTAL_ADDRESS_CITY.pid = 27;

            WPD_CONTACT_OTHER_POSTAL_ADDRESS_REGION.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_POSTAL_ADDRESS_REGION.pid = 28;

            WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_CODE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_CODE.pid = 29;

            WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_COUNTRY.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_COUNTRY.pid = 30;

            WPD_CONTACT_PRIMARY_EMAIL_ADDRESS.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PRIMARY_EMAIL_ADDRESS.pid = 31;

            WPD_CONTACT_PERSONAL_EMAIL.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_EMAIL.pid = 32;

            WPD_CONTACT_PERSONAL_EMAIL2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_EMAIL2.pid = 33;

            WPD_CONTACT_BUSINESS_EMAIL.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_EMAIL.pid = 34;

            WPD_CONTACT_BUSINESS_EMAIL2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_EMAIL2.pid = 35;

            WPD_CONTACT_OTHER_EMAILS.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_EMAILS.pid = 36;

            WPD_CONTACT_PRIMARY_PHONE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PRIMARY_PHONE.pid = 37;

            WPD_CONTACT_PERSONAL_PHONE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_PHONE.pid = 38;

            WPD_CONTACT_PERSONAL_PHONE2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_PHONE2.pid = 39;

            WPD_CONTACT_BUSINESS_PHONE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_PHONE.pid = 40;

            WPD_CONTACT_BUSINESS_PHONE2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_PHONE2.pid = 41;

            WPD_CONTACT_MOBILE_PHONE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_MOBILE_PHONE.pid = 42;

            WPD_CONTACT_MOBILE_PHONE2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_MOBILE_PHONE2.pid = 43;

            WPD_CONTACT_PERSONAL_FAX.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_FAX.pid = 44;

            WPD_CONTACT_BUSINESS_FAX.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_FAX.pid = 45;

            WPD_CONTACT_PAGER.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PAGER.pid = 46;

            WPD_CONTACT_OTHER_PHONES.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_OTHER_PHONES.pid = 47;

            WPD_CONTACT_PRIMARY_WEB_ADDRESS.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PRIMARY_WEB_ADDRESS.pid = 48;

            WPD_CONTACT_PERSONAL_WEB_ADDRESS.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PERSONAL_WEB_ADDRESS.pid = 49;

            WPD_CONTACT_BUSINESS_WEB_ADDRESS.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BUSINESS_WEB_ADDRESS.pid = 50;

            WPD_CONTACT_INSTANT_MESSENGER.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_INSTANT_MESSENGER.pid = 51;

            WPD_CONTACT_INSTANT_MESSENGER2.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_INSTANT_MESSENGER2.pid = 52;

            WPD_CONTACT_INSTANT_MESSENGER3.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_INSTANT_MESSENGER3.pid = 53;

            WPD_CONTACT_COMPANY_NAME.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_COMPANY_NAME.pid = 54;

            WPD_CONTACT_PHONETIC_COMPANY_NAME.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PHONETIC_COMPANY_NAME.pid = 55;

            WPD_CONTACT_ROLE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_ROLE.pid = 56;

            WPD_CONTACT_BIRTHDATE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_BIRTHDATE.pid = 57;

            WPD_CONTACT_PRIMARY_FAX.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_PRIMARY_FAX.pid = 58;

            WPD_CONTACT_SPOUSE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_SPOUSE.pid = 59;

            WPD_CONTACT_CHILDREN.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_CHILDREN.pid = 60;

            WPD_CONTACT_ASSISTANT.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_ASSISTANT.pid = 61;

            WPD_CONTACT_ANNIVERSARY_DATE.fmtid = new Guid(0xFBD4FDAB, 0x987D, 0x4777, 0xB3, 0xF9, 0x72, 0x61, 0x85, 0xA9, 0x31, 0x2B);
            WPD_CONTACT_ANNIVERSARY_DATE.pid = 62;

            WPD_MUSIC_ALBUM.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_MUSIC_ALBUM.pid = 3;

            WPD_MUSIC_TRACK.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_MUSIC_TRACK.pid = 4;

            WPD_MUSIC_LYRICS.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_MUSIC_LYRICS.pid = 6;

            WPD_MUSIC_MOOD.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_MUSIC_MOOD.pid = 8;

            WPD_AUDIO_BITRATE.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_AUDIO_BITRATE.pid = 9;

            WPD_AUDIO_CHANNEL_COUNT.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_AUDIO_CHANNEL_COUNT.pid = 10;

            WPD_AUDIO_FORMAT_CODE.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_AUDIO_FORMAT_CODE.pid = 11;

            WPD_AUDIO_BIT_DEPTH.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_AUDIO_BIT_DEPTH.pid = 12;

            WPD_AUDIO_BLOCK_ALIGNMENT.fmtid = new Guid(0xB324F56A, 0xDC5D, 0x46E5, 0xB6, 0xDF, 0xD2, 0xEA, 0x41, 0x48, 0x88, 0xC6);
            WPD_AUDIO_BLOCK_ALIGNMENT.pid = 13;

            WPD_VIDEO_AUTHOR.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_AUTHOR.pid = 2;

            WPD_VIDEO_RECORDEDTV_STATION_NAME.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_RECORDEDTV_STATION_NAME.pid = 4;

            WPD_VIDEO_RECORDEDTV_CHANNEL_NUMBER.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_RECORDEDTV_CHANNEL_NUMBER.pid = 5;

            WPD_VIDEO_RECORDEDTV_REPEAT.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_RECORDEDTV_REPEAT.pid = 7;

            WPD_VIDEO_BUFFER_SIZE.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_BUFFER_SIZE.pid = 8;

            WPD_VIDEO_CREDITS.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_CREDITS.pid = 9;

            WPD_VIDEO_KEY_FRAME_DISTANCE.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_KEY_FRAME_DISTANCE.pid = 10;

            WPD_VIDEO_QUALITY_SETTING.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_QUALITY_SETTING.pid = 11;

            WPD_VIDEO_SCAN_TYPE.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_SCAN_TYPE.pid = 12;

            WPD_VIDEO_BITRATE.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_BITRATE.pid = 13;

            WPD_VIDEO_FOURCC_CODE.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_FOURCC_CODE.pid = 14;

            WPD_VIDEO_FRAMERATE.fmtid = new Guid(0x346F2163, 0xF998, 0x4146, 0x8B, 0x01, 0xD1, 0x9B, 0x4C, 0x00, 0xDE, 0x9A);
            WPD_VIDEO_FRAMERATE.pid = 15;

            WPD_COMMON_INFORMATION_SUBJECT.fmtid = new Guid(0xB28AE94B, 0x05A4, 0x4E8E, 0xBE, 0x01, 0x72, 0xCC, 0x7E, 0x09, 0x9D, 0x8F);
            WPD_COMMON_INFORMATION_SUBJECT.pid = 2;

            WPD_COMMON_INFORMATION_BODY_TEXT.fmtid = new Guid(0xB28AE94B, 0x05A4, 0x4E8E, 0xBE, 0x01, 0x72, 0xCC, 0x7E, 0x09, 0x9D, 0x8F);
            WPD_COMMON_INFORMATION_BODY_TEXT.pid = 3;

            WPD_COMMON_INFORMATION_PRIORITY.fmtid = new Guid(0xB28AE94B, 0x05A4, 0x4E8E, 0xBE, 0x01, 0x72, 0xCC, 0x7E, 0x09, 0x9D, 0x8F);
            WPD_COMMON_INFORMATION_PRIORITY.pid = 4;

            WPD_COMMON_INFORMATION_START_DATETIME.fmtid = new Guid(0xB28AE94B, 0x05A4, 0x4E8E, 0xBE, 0x01, 0x72, 0xCC, 0x7E, 0x09, 0x9D, 0x8F);
            WPD_COMMON_INFORMATION_START_DATETIME.pid = 5;

            WPD_COMMON_INFORMATION_END_DATETIME.fmtid = new Guid(0xB28AE94B, 0x05A4, 0x4E8E, 0xBE, 0x01, 0x72, 0xCC, 0x7E, 0x09, 0x9D, 0x8F);
            WPD_COMMON_INFORMATION_END_DATETIME.pid = 6;

            WPD_COMMON_INFORMATION_NOTES.fmtid = new Guid(0xB28AE94B, 0x05A4, 0x4E8E, 0xBE, 0x01, 0x72, 0xCC, 0x7E, 0x09, 0x9D, 0x8F);
            WPD_COMMON_INFORMATION_NOTES.pid = 7;

            WPD_EMAIL_TO_LINE.fmtid = new Guid(0x41F8F65A, 0x5484, 0x4782, 0xB1, 0x3D, 0x47, 0x40, 0xDD, 0x7C, 0x37, 0xC5);
            WPD_EMAIL_TO_LINE.pid = 2;

            WPD_EMAIL_CC_LINE.fmtid = new Guid(0x41F8F65A, 0x5484, 0x4782, 0xB1, 0x3D, 0x47, 0x40, 0xDD, 0x7C, 0x37, 0xC5);
            WPD_EMAIL_CC_LINE.pid = 3;

            WPD_EMAIL_BCC_LINE.fmtid = new Guid(0x41F8F65A, 0x5484, 0x4782, 0xB1, 0x3D, 0x47, 0x40, 0xDD, 0x7C, 0x37, 0xC5);
            WPD_EMAIL_BCC_LINE.pid = 4;

            WPD_EMAIL_HAS_BEEN_READ.fmtid = new Guid(0x41F8F65A, 0x5484, 0x4782, 0xB1, 0x3D, 0x47, 0x40, 0xDD, 0x7C, 0x37, 0xC5);
            WPD_EMAIL_HAS_BEEN_READ.pid = 7;

            WPD_EMAIL_RECEIVED_TIME.fmtid = new Guid(0x41F8F65A, 0x5484, 0x4782, 0xB1, 0x3D, 0x47, 0x40, 0xDD, 0x7C, 0x37, 0xC5);
            WPD_EMAIL_RECEIVED_TIME.pid = 8;

            WPD_EMAIL_HAS_ATTACHMENTS.fmtid = new Guid(0x41F8F65A, 0x5484, 0x4782, 0xB1, 0x3D, 0x47, 0x40, 0xDD, 0x7C, 0x37, 0xC5);
            WPD_EMAIL_HAS_ATTACHMENTS.pid = 9;

            WPD_EMAIL_SENDER_ADDRESS.fmtid = new Guid(0x41F8F65A, 0x5484, 0x4782, 0xB1, 0x3D, 0x47, 0x40, 0xDD, 0x7C, 0x37, 0xC5);
            WPD_EMAIL_SENDER_ADDRESS.pid = 10;

            WPD_APPOINTMENT_LOCATION.fmtid = new Guid(0xF99EFD03, 0x431D, 0x40D8, 0xA1, 0xC9, 0x4E, 0x22, 0x0D, 0x9C, 0x88, 0xD3);
            WPD_APPOINTMENT_LOCATION.pid = 3;

            WPD_APPOINTMENT_TYPE.fmtid = new Guid(0xF99EFD03, 0x431D, 0x40D8, 0xA1, 0xC9, 0x4E, 0x22, 0x0D, 0x9C, 0x88, 0xD3);
            WPD_APPOINTMENT_TYPE.pid = 7;

            WPD_APPOINTMENT_REQUIRED_ATTENDEES.fmtid = new Guid(0xF99EFD03, 0x431D, 0x40D8, 0xA1, 0xC9, 0x4E, 0x22, 0x0D, 0x9C, 0x88, 0xD3);
            WPD_APPOINTMENT_REQUIRED_ATTENDEES.pid = 8;

            WPD_APPOINTMENT_OPTIONAL_ATTENDEES.fmtid = new Guid(0xF99EFD03, 0x431D, 0x40D8, 0xA1, 0xC9, 0x4E, 0x22, 0x0D, 0x9C, 0x88, 0xD3);
            WPD_APPOINTMENT_OPTIONAL_ATTENDEES.pid = 9;

            WPD_APPOINTMENT_ACCEPTED_ATTENDEES.fmtid = new Guid(0xF99EFD03, 0x431D, 0x40D8, 0xA1, 0xC9, 0x4E, 0x22, 0x0D, 0x9C, 0x88, 0xD3);
            WPD_APPOINTMENT_ACCEPTED_ATTENDEES.pid = 10;

            WPD_APPOINTMENT_RESOURCES.fmtid = new Guid(0xF99EFD03, 0x431D, 0x40D8, 0xA1, 0xC9, 0x4E, 0x22, 0x0D, 0x9C, 0x88, 0xD3);
            WPD_APPOINTMENT_RESOURCES.pid = 11;

            WPD_APPOINTMENT_TENTATIVE_ATTENDEES.fmtid = new Guid(0xF99EFD03, 0x431D, 0x40D8, 0xA1, 0xC9, 0x4E, 0x22, 0x0D, 0x9C, 0x88, 0xD3);
            WPD_APPOINTMENT_TENTATIVE_ATTENDEES.pid = 12;

            WPD_APPOINTMENT_DECLINED_ATTENDEES.fmtid = new Guid(0xF99EFD03, 0x431D, 0x40D8, 0xA1, 0xC9, 0x4E, 0x22, 0x0D, 0x9C, 0x88, 0xD3);
            WPD_APPOINTMENT_DECLINED_ATTENDEES.pid = 13;

            WPD_TASK_STATUS.fmtid = new Guid(0xE354E95E, 0xD8A0, 0x4637, 0xA0, 0x3A, 0x0C, 0xB2, 0x68, 0x38, 0xDB, 0xC7);
            WPD_TASK_STATUS.pid = 6;

            WPD_TASK_PERCENT_COMPLETE.fmtid = new Guid(0xE354E95E, 0xD8A0, 0x4637, 0xA0, 0x3A, 0x0C, 0xB2, 0x68, 0x38, 0xDB, 0xC7);
            WPD_TASK_PERCENT_COMPLETE.pid = 8;

            WPD_TASK_REMINDER_DATE.fmtid = new Guid(0xE354E95E, 0xD8A0, 0x4637, 0xA0, 0x3A, 0x0C, 0xB2, 0x68, 0x38, 0xDB, 0xC7);
            WPD_TASK_REMINDER_DATE.pid = 10;

            WPD_TASK_OWNER.fmtid = new Guid(0xE354E95E, 0xD8A0, 0x4637, 0xA0, 0x3A, 0x0C, 0xB2, 0x68, 0x38, 0xDB, 0xC7);
            WPD_TASK_OWNER.pid = 11;

            WPD_STORAGE_TYPE.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_TYPE.pid = 2;

            WPD_STORAGE_FILE_SYSTEM_TYPE.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_FILE_SYSTEM_TYPE.pid = 3;

            WPD_STORAGE_CAPACITY.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_CAPACITY.pid = 4;

            WPD_STORAGE_FREE_SPACE_IN_BYTES.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_FREE_SPACE_IN_BYTES.pid = 5;

            WPD_STORAGE_FREE_SPACE_IN_OBJECTS.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_FREE_SPACE_IN_OBJECTS.pid = 6;

            WPD_STORAGE_DESCRIPTION.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_DESCRIPTION.pid = 7;

            WPD_STORAGE_SERIAL_NUMBER.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_SERIAL_NUMBER.pid = 8;

            WPD_STORAGE_MAX_OBJECT_SIZE.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_MAX_OBJECT_SIZE.pid = 9;

            WPD_STORAGE_CAPACITY_IN_OBJECTS.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_CAPACITY_IN_OBJECTS.pid = 10;

            WPD_STORAGE_ACCESS_CAPABILITY.fmtid = new Guid(0x01A3057A, 0x74D6, 0x4E80, 0xBE, 0xA7, 0xDC, 0x4C, 0x21, 0x2C, 0xE5, 0x0A);
            WPD_STORAGE_ACCESS_CAPABILITY.pid = 11;

            WPD_NETWORK_ASSOCIATION_HOST_NETWORK_IDENTIFIERS.fmtid = new Guid(0xE4C93C1F, 0xB203, 0x43F1, 0xA1, 0x00, 0x5A, 0x07, 0xD1, 0x1B, 0x02, 0x74);
            WPD_NETWORK_ASSOCIATION_HOST_NETWORK_IDENTIFIERS.pid = 2;

            WPD_NETWORK_ASSOCIATION_X509V3SEQUENCE.fmtid = new Guid(0xE4C93C1F, 0xB203, 0x43F1, 0xA1, 0x00, 0x5A, 0x07, 0xD1, 0x1B, 0x02, 0x74);
            WPD_NETWORK_ASSOCIATION_X509V3SEQUENCE.pid = 3;

            WPD_STILL_IMAGE_CAPTURE_RESOLUTION.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_CAPTURE_RESOLUTION.pid = 2;

            WPD_STILL_IMAGE_CAPTURE_FORMAT.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_CAPTURE_FORMAT.pid = 3;

            WPD_STILL_IMAGE_COMPRESSION_SETTING.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_COMPRESSION_SETTING.pid = 4;

            WPD_STILL_IMAGE_WHITE_BALANCE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_WHITE_BALANCE.pid = 5;

            WPD_STILL_IMAGE_RGB_GAIN.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_RGB_GAIN.pid = 6;

            WPD_STILL_IMAGE_FNUMBER.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_FNUMBER.pid = 7;

            WPD_STILL_IMAGE_FOCAL_LENGTH.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_FOCAL_LENGTH.pid = 8;

            WPD_STILL_IMAGE_FOCUS_DISTANCE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_FOCUS_DISTANCE.pid = 9;

            WPD_STILL_IMAGE_FOCUS_MODE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_FOCUS_MODE.pid = 10;

            WPD_STILL_IMAGE_EXPOSURE_METERING_MODE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_EXPOSURE_METERING_MODE.pid = 11;

            WPD_STILL_IMAGE_FLASH_MODE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_FLASH_MODE.pid = 12;

            WPD_STILL_IMAGE_EXPOSURE_TIME.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_EXPOSURE_TIME.pid = 13;

            WPD_STILL_IMAGE_EXPOSURE_PROGRAM_MODE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_EXPOSURE_PROGRAM_MODE.pid = 14;

            WPD_STILL_IMAGE_EXPOSURE_INDEX.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_EXPOSURE_INDEX.pid = 15;

            WPD_STILL_IMAGE_EXPOSURE_BIAS_COMPENSATION.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_EXPOSURE_BIAS_COMPENSATION.pid = 16;

            WPD_STILL_IMAGE_CAPTURE_DELAY.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_CAPTURE_DELAY.pid = 17;

            WPD_STILL_IMAGE_CAPTURE_MODE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_CAPTURE_MODE.pid = 18;

            WPD_STILL_IMAGE_CONTRAST.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_CONTRAST.pid = 19;

            WPD_STILL_IMAGE_SHARPNESS.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_SHARPNESS.pid = 20;

            WPD_STILL_IMAGE_DIGITAL_ZOOM.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_DIGITAL_ZOOM.pid = 21;

            WPD_STILL_IMAGE_EFFECT_MODE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_EFFECT_MODE.pid = 22;

            WPD_STILL_IMAGE_BURST_NUMBER.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_BURST_NUMBER.pid = 23;

            WPD_STILL_IMAGE_BURST_INTERVAL.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_BURST_INTERVAL.pid = 24;

            WPD_STILL_IMAGE_TIMELAPSE_NUMBER.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_TIMELAPSE_NUMBER.pid = 25;

            WPD_STILL_IMAGE_TIMELAPSE_INTERVAL.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_TIMELAPSE_INTERVAL.pid = 26;

            WPD_STILL_IMAGE_FOCUS_METERING_MODE.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_FOCUS_METERING_MODE.pid = 27;

            WPD_STILL_IMAGE_UPLOAD_URL.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_UPLOAD_URL.pid = 28;

            WPD_STILL_IMAGE_ARTIST.fmtid = new Guid(0x58C571EC, 0x1BCB, 0x42A7, 0x8A, 0xC5, 0xBB, 0x29, 0x15, 0x73, 0xA2, 0x60);
            WPD_STILL_IMAGE_ARTIST.pid = 29;

            WPD_SMS_PROVIDER.fmtid = new Guid(0x7E1074CC, 0x50FF, 0x4DD1, 0xA7, 0x42, 0x53, 0xBE, 0x6F, 0x09, 0x3A, 0x0D);
            WPD_SMS_PROVIDER.pid = 2;

            WPD_SMS_TIMEOUT.fmtid = new Guid(0x7E1074CC, 0x50FF, 0x4DD1, 0xA7, 0x42, 0x53, 0xBE, 0x6F, 0x09, 0x3A, 0x0D);
            WPD_SMS_TIMEOUT.pid = 3;

            WPD_SMS_MAX_PAYLOAD.fmtid = new Guid(0x7E1074CC, 0x50FF, 0x4DD1, 0xA7, 0x42, 0x53, 0xBE, 0x6F, 0x09, 0x3A, 0x0D);
            WPD_SMS_MAX_PAYLOAD.pid = 4;

            WPD_SMS_ENCODING.fmtid = new Guid(0x7E1074CC, 0x50FF, 0x4DD1, 0xA7, 0x42, 0x53, 0xBE, 0x6F, 0x09, 0x3A, 0x0D);
            WPD_SMS_ENCODING.pid = 5;

            WPD_SECTION_DATA_OFFSET.fmtid = new Guid(0x516AFD2B, 0xC64E, 0x44F0, 0x98, 0xDC, 0xBE, 0xE1, 0xC8, 0x8F, 0x7D, 0x66);
            WPD_SECTION_DATA_OFFSET.pid = 2;

            WPD_SECTION_DATA_LENGTH.fmtid = new Guid(0x516AFD2B, 0xC64E, 0x44F0, 0x98, 0xDC, 0xBE, 0xE1, 0xC8, 0x8F, 0x7D, 0x66);
            WPD_SECTION_DATA_LENGTH.pid = 3;

            WPD_SECTION_DATA_UNITS.fmtid = new Guid(0x516AFD2B, 0xC64E, 0x44F0, 0x98, 0xDC, 0xBE, 0xE1, 0xC8, 0x8F, 0x7D, 0x66);
            WPD_SECTION_DATA_UNITS.pid = 4;

            WPD_SECTION_DATA_REFERENCED_OBJECT_RESOURCE.fmtid = new Guid(0x516AFD2B, 0xC64E, 0x44F0, 0x98, 0xDC, 0xBE, 0xE1, 0xC8, 0x8F, 0x7D, 0x66);
            WPD_SECTION_DATA_REFERENCED_OBJECT_RESOURCE.pid = 5;

            WPD_RENDERING_INFORMATION_PROFILES.fmtid = new Guid(0xC53D039F, 0xEE23, 0x4A31, 0x85, 0x90, 0x76, 0x39, 0x87, 0x98, 0x70, 0xB4);
            WPD_RENDERING_INFORMATION_PROFILES.pid = 2;

            WPD_RENDERING_INFORMATION_PROFILE_ENTRY_TYPE.fmtid = new Guid(0xC53D039F, 0xEE23, 0x4A31, 0x85, 0x90, 0x76, 0x39, 0x87, 0x98, 0x70, 0xB4);
            WPD_RENDERING_INFORMATION_PROFILE_ENTRY_TYPE.pid = 3;

            WPD_RENDERING_INFORMATION_PROFILE_ENTRY_CREATABLE_RESOURCES.fmtid = new Guid(0xC53D039F, 0xEE23, 0x4A31, 0x85, 0x90, 0x76, 0x39, 0x87, 0x98, 0x70, 0xB4);
            WPD_RENDERING_INFORMATION_PROFILE_ENTRY_CREATABLE_RESOURCES.pid = 4;

            WPD_CLIENT_NAME.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_NAME.pid = 2;

            WPD_CLIENT_MAJOR_VERSION.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_MAJOR_VERSION.pid = 3;

            WPD_CLIENT_MINOR_VERSION.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_MINOR_VERSION.pid = 4;

            WPD_CLIENT_REVISION.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_REVISION.pid = 5;

            WPD_CLIENT_WMDRM_APPLICATION_PRIVATE_KEY.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_WMDRM_APPLICATION_PRIVATE_KEY.pid = 6;

            WPD_CLIENT_WMDRM_APPLICATION_CERTIFICATE.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_WMDRM_APPLICATION_CERTIFICATE.pid = 7;

            WPD_CLIENT_SECURITY_QUALITY_OF_SERVICE.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_SECURITY_QUALITY_OF_SERVICE.pid = 8;

            WPD_CLIENT_DESIRED_ACCESS.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_DESIRED_ACCESS.pid = 9;

            WPD_CLIENT_SHARE_MODE.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_SHARE_MODE.pid = 10;

            WPD_CLIENT_EVENT_COOKIE.fmtid = new Guid(0x204D9F0C, 0x2292, 0x4080, 0x9F, 0x42, 0x40, 0x66, 0x4E, 0x70, 0xF8, 0x59);
            WPD_CLIENT_EVENT_COOKIE.pid = 11;

            WPD_PROPERTY_ATTRIBUTE_FORM.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_FORM.pid = 2;

            WPD_PROPERTY_ATTRIBUTE_CAN_READ.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_CAN_READ.pid = 3;

            WPD_PROPERTY_ATTRIBUTE_CAN_WRITE.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_CAN_WRITE.pid = 4;

            WPD_PROPERTY_ATTRIBUTE_CAN_DELETE.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_CAN_DELETE.pid = 5;

            WPD_PROPERTY_ATTRIBUTE_DEFAULT_VALUE.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_DEFAULT_VALUE.pid = 6;

            WPD_PROPERTY_ATTRIBUTE_FAST_PROPERTY.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_FAST_PROPERTY.pid = 7;

            WPD_PROPERTY_ATTRIBUTE_RANGE_MIN.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_RANGE_MIN.pid = 8;

            WPD_PROPERTY_ATTRIBUTE_RANGE_MAX.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_RANGE_MAX.pid = 9;

            WPD_PROPERTY_ATTRIBUTE_RANGE_STEP.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_RANGE_STEP.pid = 10;

            WPD_PROPERTY_ATTRIBUTE_ENUMERATION_ELEMENTS.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_ENUMERATION_ELEMENTS.pid = 11;

            WPD_PROPERTY_ATTRIBUTE_REGULAR_EXPRESSION.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_REGULAR_EXPRESSION.pid = 12;

            WPD_PROPERTY_ATTRIBUTE_MAX_SIZE.fmtid = new Guid(0xAB7943D8, 0x6332, 0x445F, 0xA0, 0x0D, 0x8D, 0x5E, 0xF1, 0xE9, 0x6F, 0x37);
            WPD_PROPERTY_ATTRIBUTE_MAX_SIZE.pid = 13;

            WPD_CLASS_EXTENSION_OPTIONS_SUPPORTED_CONTENT_TYPES.fmtid = new Guid(0x6309FFEF, 0xA87C, 0x4CA7, 0x84, 0x34, 0x79, 0x75, 0x76, 0xE4, 0x0A, 0x96);
            WPD_CLASS_EXTENSION_OPTIONS_SUPPORTED_CONTENT_TYPES.pid = 2;

            WPD_CLASS_EXTENSION_OPTIONS_DONT_REGISTER_WPD_DEVICE_INTERFACE.fmtid = new Guid(0x6309FFEF, 0xA87C, 0x4CA7, 0x84, 0x34, 0x79, 0x75, 0x76, 0xE4, 0x0A, 0x96);
            WPD_CLASS_EXTENSION_OPTIONS_DONT_REGISTER_WPD_DEVICE_INTERFACE.pid = 3;

            WPD_CLASS_EXTENSION_OPTIONS_REGISTER_WPD_PRIVATE_DEVICE_INTERFACE.fmtid = new Guid(0x6309FFEF, 0xA87C, 0x4CA7, 0x84, 0x34, 0x79, 0x75, 0x76, 0xE4, 0x0A, 0x96);
            WPD_CLASS_EXTENSION_OPTIONS_REGISTER_WPD_PRIVATE_DEVICE_INTERFACE.pid = 4;

            WPD_RESOURCE_ATTRIBUTE_TOTAL_SIZE.fmtid = new Guid(0x1EB6F604, 0x9278, 0x429F, 0x93, 0xCC, 0x5B, 0xB8, 0xC0, 0x66, 0x56, 0xB6);
            WPD_RESOURCE_ATTRIBUTE_TOTAL_SIZE.pid = 2;

            WPD_RESOURCE_ATTRIBUTE_CAN_READ.fmtid = new Guid(0x1EB6F604, 0x9278, 0x429F, 0x93, 0xCC, 0x5B, 0xB8, 0xC0, 0x66, 0x56, 0xB6);
            WPD_RESOURCE_ATTRIBUTE_CAN_READ.pid = 3;

            WPD_RESOURCE_ATTRIBUTE_CAN_WRITE.fmtid = new Guid(0x1EB6F604, 0x9278, 0x429F, 0x93, 0xCC, 0x5B, 0xB8, 0xC0, 0x66, 0x56, 0xB6);
            WPD_RESOURCE_ATTRIBUTE_CAN_WRITE.pid = 4;

            WPD_RESOURCE_ATTRIBUTE_CAN_DELETE.fmtid = new Guid(0x1EB6F604, 0x9278, 0x429F, 0x93, 0xCC, 0x5B, 0xB8, 0xC0, 0x66, 0x56, 0xB6);
            WPD_RESOURCE_ATTRIBUTE_CAN_DELETE.pid = 5;

            WPD_RESOURCE_ATTRIBUTE_OPTIMAL_READ_BUFFER_SIZE.fmtid = new Guid(0x1EB6F604, 0x9278, 0x429F, 0x93, 0xCC, 0x5B, 0xB8, 0xC0, 0x66, 0x56, 0xB6);
            WPD_RESOURCE_ATTRIBUTE_OPTIMAL_READ_BUFFER_SIZE.pid = 6;

            WPD_RESOURCE_ATTRIBUTE_OPTIMAL_WRITE_BUFFER_SIZE.fmtid = new Guid(0x1EB6F604, 0x9278, 0x429F, 0x93, 0xCC, 0x5B, 0xB8, 0xC0, 0x66, 0x56, 0xB6);
            WPD_RESOURCE_ATTRIBUTE_OPTIMAL_WRITE_BUFFER_SIZE.pid = 7;

            WPD_RESOURCE_ATTRIBUTE_FORMAT.fmtid = new Guid(0x1EB6F604, 0x9278, 0x429F, 0x93, 0xCC, 0x5B, 0xB8, 0xC0, 0x66, 0x56, 0xB6);
            WPD_RESOURCE_ATTRIBUTE_FORMAT.pid = 8;

            WPD_RESOURCE_ATTRIBUTE_RESOURCE_KEY.fmtid = new Guid(0x1EB6F604, 0x9278, 0x429F, 0x93, 0xCC, 0x5B, 0xB8, 0xC0, 0x66, 0x56, 0xB6);
            WPD_RESOURCE_ATTRIBUTE_RESOURCE_KEY.pid = 9;

            WPD_DEVICE_SYNC_PARTNER.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_SYNC_PARTNER.pid = 2;

            WPD_DEVICE_FIRMWARE_VERSION.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_FIRMWARE_VERSION.pid = 3;

            WPD_DEVICE_POWER_LEVEL.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_POWER_LEVEL.pid = 4;

            WPD_DEVICE_POWER_SOURCE.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_POWER_SOURCE.pid = 5;

            WPD_DEVICE_PROTOCOL.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_PROTOCOL.pid = 6;

            WPD_DEVICE_MANUFACTURER.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_MANUFACTURER.pid = 7;

            WPD_DEVICE_MODEL.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_MODEL.pid = 8;

            WPD_DEVICE_SERIAL_NUMBER.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_SERIAL_NUMBER.pid = 9;

            WPD_DEVICE_SUPPORTS_NON_CONSUMABLE.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_SUPPORTS_NON_CONSUMABLE.pid = 10;

            WPD_DEVICE_DATETIME.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_DATETIME.pid = 11;

            WPD_DEVICE_FRIENDLY_NAME.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_FRIENDLY_NAME.pid = 12;

            WPD_DEVICE_SUPPORTED_DRM_SCHEMES.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_SUPPORTED_DRM_SCHEMES.pid = 13;

            WPD_DEVICE_SUPPORTED_FORMATS_ARE_ORDERED.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_SUPPORTED_FORMATS_ARE_ORDERED.pid = 14;

            WPD_DEVICE_TYPE.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_TYPE.pid = 15;

            WPD_DEVICE_NETWORK_IDENTIFIER.fmtid = new Guid(0x26D4979A, 0xE643, 0x4626, 0x9E, 0x2B, 0x73, 0x6D, 0xC0, 0xC9, 0x2F, 0xDC);
            WPD_DEVICE_NETWORK_IDENTIFIER.pid = 16;

            WPD_EVENT_PARAMETER_PNP_DEVICE_ID.fmtid = new Guid(0x15AB1953, 0xF817, 0x4FEF, 0xA9, 0x21, 0x56, 0x76, 0xE8, 0x38, 0xF6, 0xE0);
            WPD_EVENT_PARAMETER_PNP_DEVICE_ID.pid = 2;

            WPD_EVENT_PARAMETER_EVENT_ID.fmtid = new Guid(0x15AB1953, 0xF817, 0x4FEF, 0xA9, 0x21, 0x56, 0x76, 0xE8, 0x38, 0xF6, 0xE0);
            WPD_EVENT_PARAMETER_EVENT_ID.pid = 3;

            WPD_EVENT_PARAMETER_OPERATION_STATE.fmtid = new Guid(0x15AB1953, 0xF817, 0x4FEF, 0xA9, 0x21, 0x56, 0x76, 0xE8, 0x38, 0xF6, 0xE0);
            WPD_EVENT_PARAMETER_OPERATION_STATE.pid = 4;

            WPD_EVENT_PARAMETER_OPERATION_PROGRESS.fmtid = new Guid(0x15AB1953, 0xF817, 0x4FEF, 0xA9, 0x21, 0x56, 0x76, 0xE8, 0x38, 0xF6, 0xE0);
            WPD_EVENT_PARAMETER_OPERATION_PROGRESS.pid = 5;

            WPD_EVENT_PARAMETER_OBJECT_PARENT_PERSISTENT_UNIQUE_ID.fmtid = new Guid(0x15AB1953, 0xF817, 0x4FEF, 0xA9, 0x21, 0x56, 0x76, 0xE8, 0x38, 0xF6, 0xE0);
            WPD_EVENT_PARAMETER_OBJECT_PARENT_PERSISTENT_UNIQUE_ID.pid = 6;

            WPD_EVENT_PARAMETER_OBJECT_CREATION_COOKIE.fmtid = new Guid(0x15AB1953, 0xF817, 0x4FEF, 0xA9, 0x21, 0x56, 0x76, 0xE8, 0x38, 0xF6, 0xE0);
            WPD_EVENT_PARAMETER_OBJECT_CREATION_COOKIE.pid = 7;

            WPD_EVENT_PARAMETER_CHILD_HIERARCHY_CHANGED.fmtid = new Guid(0x15AB1953, 0xF817, 0x4FEF, 0xA9, 0x21, 0x56, 0x76, 0xE8, 0x38, 0xF6, 0xE0);
            WPD_EVENT_PARAMETER_CHILD_HIERARCHY_CHANGED.pid = 8;

            WPD_EVENT_OPTION_IS_BROADCAST_EVENT.fmtid = new Guid(0xB3D8DAD7, 0xA361, 0x4B83, 0x8A, 0x48, 0x5B, 0x02, 0xCE, 0x10, 0x71, 0x3B);
            WPD_EVENT_OPTION_IS_BROADCAST_EVENT.pid = 2;

            WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT.fmtid = new Guid(0xB3D8DAD7, 0xA361, 0x4B83, 0x8A, 0x48, 0x5B, 0x02, 0xCE, 0x10, 0x71, 0x3B);
            WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT.pid = 3;

            WPD_API_OPTION_USE_CLEAR_DATA_STREAM.fmtid = new Guid(0x10E54A3E, 0x052D, 0x4777, 0xA1, 0x3C, 0xDE, 0x76, 0x14, 0xBE, 0x2B, 0xC4);
            WPD_API_OPTION_USE_CLEAR_DATA_STREAM.pid = 2;

            WPD_API_OPTION_IOCTL_ACCESS.fmtid = new Guid(0x10E54A3E, 0x052D, 0x4777, 0xA1, 0x3C, 0xDE, 0x76, 0x14, 0xBE, 0x2B, 0xC4);
            WPD_API_OPTION_IOCTL_ACCESS.pid = 3;

            WPD_COMMAND_COMMON_RESET_DEVICE.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_COMMAND_COMMON_RESET_DEVICE.pid = 2;

            WPD_COMMAND_COMMON_GET_OBJECT_IDS_FROM_PERSISTENT_UNIQUE_IDS.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_COMMAND_COMMON_GET_OBJECT_IDS_FROM_PERSISTENT_UNIQUE_IDS.pid = 3;

            WPD_COMMAND_COMMON_SAVE_CLIENT_INFORMATION.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_COMMAND_COMMON_SAVE_CLIENT_INFORMATION.pid = 4;

            WPD_PROPERTY_COMMON_COMMAND_CATEGORY.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_COMMAND_CATEGORY.pid = 1001;

            WPD_PROPERTY_COMMON_COMMAND_ID.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_COMMAND_ID.pid = 1002;

            WPD_PROPERTY_COMMON_HRESULT.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_HRESULT.pid = 1003;

            WPD_PROPERTY_COMMON_DRIVER_ERROR_CODE.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_DRIVER_ERROR_CODE.pid = 1004;

            WPD_PROPERTY_COMMON_COMMAND_TARGET.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_COMMAND_TARGET.pid = 1006;

            WPD_PROPERTY_COMMON_PERSISTENT_UNIQUE_IDS.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_PERSISTENT_UNIQUE_IDS.pid = 1007;

            WPD_PROPERTY_COMMON_OBJECT_IDS.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_OBJECT_IDS.pid = 1008;

            WPD_PROPERTY_COMMON_CLIENT_INFORMATION.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_CLIENT_INFORMATION.pid = 1009;

            WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT.pid = 1010;

            WPD_OPTION_VALID_OBJECT_IDS.fmtid = new Guid(0xF0422A9C, 0x5DC8, 0x4440, 0xB5, 0xBD, 0x5D, 0xF2, 0x88, 0x35, 0x65, 0x8A);
            WPD_OPTION_VALID_OBJECT_IDS.pid = 5001;

            WPD_COMMAND_OBJECT_ENUMERATION_START_FIND.fmtid = new Guid(0xB7474E91, 0xE7F8, 0x4AD9, 0xB4, 0x00, 0xAD, 0x1A, 0x4B, 0x58, 0xEE, 0xEC);
            WPD_COMMAND_OBJECT_ENUMERATION_START_FIND.pid = 2;

            WPD_COMMAND_OBJECT_ENUMERATION_FIND_NEXT.fmtid = new Guid(0xB7474E91, 0xE7F8, 0x4AD9, 0xB4, 0x00, 0xAD, 0x1A, 0x4B, 0x58, 0xEE, 0xEC);
            WPD_COMMAND_OBJECT_ENUMERATION_FIND_NEXT.pid = 3;

            WPD_COMMAND_OBJECT_ENUMERATION_END_FIND.fmtid = new Guid(0xB7474E91, 0xE7F8, 0x4AD9, 0xB4, 0x00, 0xAD, 0x1A, 0x4B, 0x58, 0xEE, 0xEC);
            WPD_COMMAND_OBJECT_ENUMERATION_END_FIND.pid = 4;

            WPD_PROPERTY_OBJECT_ENUMERATION_PARENT_ID.fmtid = new Guid(0xB7474E91, 0xE7F8, 0x4AD9, 0xB4, 0x00, 0xAD, 0x1A, 0x4B, 0x58, 0xEE, 0xEC);
            WPD_PROPERTY_OBJECT_ENUMERATION_PARENT_ID.pid = 1001;

            WPD_PROPERTY_OBJECT_ENUMERATION_FILTER.fmtid = new Guid(0xB7474E91, 0xE7F8, 0x4AD9, 0xB4, 0x00, 0xAD, 0x1A, 0x4B, 0x58, 0xEE, 0xEC);
            WPD_PROPERTY_OBJECT_ENUMERATION_FILTER.pid = 1002;

            WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS.fmtid = new Guid(0xB7474E91, 0xE7F8, 0x4AD9, 0xB4, 0x00, 0xAD, 0x1A, 0x4B, 0x58, 0xEE, 0xEC);
            WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS.pid = 1003;

            WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT.fmtid = new Guid(0xB7474E91, 0xE7F8, 0x4AD9, 0xB4, 0x00, 0xAD, 0x1A, 0x4B, 0x58, 0xEE, 0xEC);
            WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT.pid = 1004;

            WPD_PROPERTY_OBJECT_ENUMERATION_NUM_OBJECTS_REQUESTED.fmtid = new Guid(0xB7474E91, 0xE7F8, 0x4AD9, 0xB4, 0x00, 0xAD, 0x1A, 0x4B, 0x58, 0xEE, 0xEC);
            WPD_PROPERTY_OBJECT_ENUMERATION_NUM_OBJECTS_REQUESTED.pid = 1005;

            WPD_COMMAND_OBJECT_PROPERTIES_GET_SUPPORTED.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_COMMAND_OBJECT_PROPERTIES_GET_SUPPORTED.pid = 2;

            WPD_COMMAND_OBJECT_PROPERTIES_GET_ATTRIBUTES.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_COMMAND_OBJECT_PROPERTIES_GET_ATTRIBUTES.pid = 3;

            WPD_COMMAND_OBJECT_PROPERTIES_GET.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_COMMAND_OBJECT_PROPERTIES_GET.pid = 4;

            WPD_COMMAND_OBJECT_PROPERTIES_SET.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_COMMAND_OBJECT_PROPERTIES_SET.pid = 5;

            WPD_COMMAND_OBJECT_PROPERTIES_GET_ALL.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_COMMAND_OBJECT_PROPERTIES_GET_ALL.pid = 6;

            WPD_COMMAND_OBJECT_PROPERTIES_DELETE.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_COMMAND_OBJECT_PROPERTIES_DELETE.pid = 7;

            WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID.pid = 1001;

            WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS.pid = 1002;

            WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES.pid = 1003;

            WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES.pid = 1004;

            WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS.fmtid = new Guid(0x9E5582E4, 0x0814, 0x44E6, 0x98, 0x1A, 0xB2, 0x99, 0x8D, 0x58, 0x38, 0x04);
            WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS.pid = 1005;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_START.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_START.pid = 2;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_NEXT.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_NEXT.pid = 3;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_END.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_END.pid = 4;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_START.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_START.pid = 5;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_NEXT.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_NEXT.pid = 6;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_END.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_END.pid = 7;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_START.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_START.pid = 8;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_NEXT.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_NEXT.pid = 9;

            WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_END.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_END.pid = 10;

            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_IDS.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_IDS.pid = 1001;

            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT.pid = 1002;

            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES.pid = 1003;

            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS.pid = 1004;

            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_DEPTH.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_DEPTH.pid = 1005;

            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PARENT_OBJECT_ID.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PARENT_OBJECT_ID.pid = 1006;

            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_FORMAT.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_FORMAT.pid = 1007;

            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS.fmtid = new Guid(0x11C824DD, 0x04CD, 0x4E4E, 0x8C, 0x7B, 0xF6, 0xEF, 0xB7, 0x94, 0xD8, 0x4E);
            WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS.pid = 1008;

            WPD_COMMAND_OBJECT_RESOURCES_GET_SUPPORTED.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_GET_SUPPORTED.pid = 2;

            WPD_COMMAND_OBJECT_RESOURCES_GET_ATTRIBUTES.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_GET_ATTRIBUTES.pid = 3;

            WPD_COMMAND_OBJECT_RESOURCES_OPEN.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_OPEN.pid = 4;

            WPD_COMMAND_OBJECT_RESOURCES_READ.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_READ.pid = 5;

            WPD_COMMAND_OBJECT_RESOURCES_WRITE.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_WRITE.pid = 6;

            WPD_COMMAND_OBJECT_RESOURCES_CLOSE.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_CLOSE.pid = 7;

            WPD_COMMAND_OBJECT_RESOURCES_DELETE.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_DELETE.pid = 8;

            WPD_COMMAND_OBJECT_RESOURCES_CREATE_RESOURCE.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_CREATE_RESOURCE.pid = 9;

            WPD_COMMAND_OBJECT_RESOURCES_REVERT.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_REVERT.pid = 10;

            WPD_COMMAND_OBJECT_RESOURCES_SEEK.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_COMMAND_OBJECT_RESOURCES_SEEK.pid = 11;

            WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID.pid = 1001;

            WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE.pid = 1002;

            WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS.pid = 1003;

            WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES.pid = 1004;

            WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT.pid = 1005;

            WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_READ.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_READ.pid = 1006;

            WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_READ.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_READ.pid = 1007;

            WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_WRITE.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_WRITE.pid = 1008;

            WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN.pid = 1009;

            WPD_PROPERTY_OBJECT_RESOURCES_DATA.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_DATA.pid = 1010;

            WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE.pid = 1011;

            WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET.pid = 1012;

            WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG.pid = 1013;

            WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START.pid = 1014;

            WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_READ_SUPPORTED.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_READ_SUPPORTED.pid = 5001;

            WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_WRITE_SUPPORTED.fmtid = new Guid(0xB3A2B22D, 0xA595, 0x4108, 0xBE, 0x0A, 0xFC, 0x3C, 0x96, 0x5F, 0x3D, 0x4A);
            WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_WRITE_SUPPORTED.pid = 5002;

            WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_ONLY.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_ONLY.pid = 2;

            WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_AND_DATA.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_AND_DATA.pid = 3;

            WPD_COMMAND_OBJECT_MANAGEMENT_WRITE_OBJECT_DATA.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_COMMAND_OBJECT_MANAGEMENT_WRITE_OBJECT_DATA.pid = 4;

            WPD_COMMAND_OBJECT_MANAGEMENT_COMMIT_OBJECT.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_COMMAND_OBJECT_MANAGEMENT_COMMIT_OBJECT.pid = 5;

            WPD_COMMAND_OBJECT_MANAGEMENT_REVERT_OBJECT.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_COMMAND_OBJECT_MANAGEMENT_REVERT_OBJECT.pid = 6;

            WPD_COMMAND_OBJECT_MANAGEMENT_DELETE_OBJECTS.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_COMMAND_OBJECT_MANAGEMENT_DELETE_OBJECTS.pid = 7;

            WPD_COMMAND_OBJECT_MANAGEMENT_MOVE_OBJECTS.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_COMMAND_OBJECT_MANAGEMENT_MOVE_OBJECTS.pid = 8;

            WPD_COMMAND_OBJECT_MANAGEMENT_COPY_OBJECTS.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_COMMAND_OBJECT_MANAGEMENT_COPY_OBJECTS.pid = 9;

            WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES.pid = 1001;

            WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT.pid = 1002;

            WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_TO_WRITE.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_TO_WRITE.pid = 1003;

            WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN.pid = 1004;

            WPD_PROPERTY_OBJECT_MANAGEMENT_DATA.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_DATA.pid = 1005;

            WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID.pid = 1006;

            WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_OPTIONS.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_OPTIONS.pid = 1007;

            WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE.pid = 1008;

            WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS.pid = 1009;

            WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS.pid = 1010;

            WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID.pid = 1011;

            WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS.pid = 1012;

            WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS.pid = 1013;

            WPD_OPTION_OBJECT_MANAGEMENT_RECURSIVE_DELETE_SUPPORTED.fmtid = new Guid(0xEF1E43DD, 0xA9ED, 0x4341, 0x8B, 0xCC, 0x18, 0x61, 0x92, 0xAE, 0xA0, 0x89);
            WPD_OPTION_OBJECT_MANAGEMENT_RECURSIVE_DELETE_SUPPORTED.pid = 5001;

            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_COMMANDS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_COMMANDS.pid = 2;

            WPD_COMMAND_CAPABILITIES_GET_COMMAND_OPTIONS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_COMMAND_OPTIONS.pid = 3;

            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES.pid = 4;

            WPD_COMMAND_CAPABILITIES_GET_FUNCTIONAL_OBJECTS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_FUNCTIONAL_OBJECTS.pid = 5;

            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES.pid = 6;

            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMATS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMATS.pid = 7;

            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES.pid = 8;

            WPD_COMMAND_CAPABILITIES_GET_FIXED_PROPERTY_ATTRIBUTES.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_FIXED_PROPERTY_ATTRIBUTES.pid = 9;

            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_EVENTS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_EVENTS.pid = 10;

            WPD_COMMAND_CAPABILITIES_GET_EVENT_OPTIONS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_COMMAND_CAPABILITIES_GET_EVENT_OPTIONS.pid = 11;

            WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS.pid = 1001;

            WPD_PROPERTY_CAPABILITIES_COMMAND.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_COMMAND.pid = 1002;

            WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS.pid = 1003;

            WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES.pid = 1004;

            WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY.pid = 1005;

            WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS.pid = 1006;

            WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES.pid = 1007;

            WPD_PROPERTY_CAPABILITIES_CONTENT_TYPE.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_CONTENT_TYPE.pid = 1008;

            WPD_PROPERTY_CAPABILITIES_FORMATS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_FORMATS.pid = 1009;

            WPD_PROPERTY_CAPABILITIES_FORMAT.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_FORMAT.pid = 1010;

            WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS.pid = 1011;

            WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES.pid = 1012;

            WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS.pid = 1013;

            WPD_PROPERTY_CAPABILITIES_EVENT.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_EVENT.pid = 1014;

            WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS.fmtid = new Guid(0x0CABEC78, 0x6B74, 0x41C6, 0x92, 0x16, 0x26, 0x39, 0xD1, 0xFC, 0xE3, 0x56);
            WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS.pid = 1015;

            WPD_COMMAND_STORAGE_FORMAT.fmtid = new Guid(0xD8F907A6, 0x34CC, 0x45FA, 0x97, 0xFB, 0xD0, 0x07, 0xFA, 0x47, 0xEC, 0x94);
            WPD_COMMAND_STORAGE_FORMAT.pid = 2;

            WPD_COMMAND_STORAGE_EJECT.fmtid = new Guid(0xD8F907A6, 0x34CC, 0x45FA, 0x97, 0xFB, 0xD0, 0x07, 0xFA, 0x47, 0xEC, 0x94);
            WPD_COMMAND_STORAGE_EJECT.pid = 4;

            WPD_PROPERTY_STORAGE_OBJECT_ID.fmtid = new Guid(0xD8F907A6, 0x34CC, 0x45FA, 0x97, 0xFB, 0xD0, 0x07, 0xFA, 0x47, 0xEC, 0x94);
            WPD_PROPERTY_STORAGE_OBJECT_ID.pid = 1001;

            WPD_PROPERTY_STORAGE_DESTINATION_OBJECT_ID.fmtid = new Guid(0xD8F907A6, 0x34CC, 0x45FA, 0x97, 0xFB, 0xD0, 0x07, 0xFA, 0x47, 0xEC, 0x94);
            WPD_PROPERTY_STORAGE_DESTINATION_OBJECT_ID.pid = 1002;

            WPD_COMMAND_SMS_SEND.fmtid = new Guid(0xAFC25D66, 0xFE0D, 0x4114, 0x90, 0x97, 0x97, 0x0C, 0x93, 0xE9, 0x20, 0xD1);
            WPD_COMMAND_SMS_SEND.pid = 2;

            WPD_PROPERTY_SMS_RECIPIENT.fmtid = new Guid(0xAFC25D66, 0xFE0D, 0x4114, 0x90, 0x97, 0x97, 0x0C, 0x93, 0xE9, 0x20, 0xD1);
            WPD_PROPERTY_SMS_RECIPIENT.pid = 1001;

            WPD_PROPERTY_SMS_MESSAGE_TYPE.fmtid = new Guid(0xAFC25D66, 0xFE0D, 0x4114, 0x90, 0x97, 0x97, 0x0C, 0x93, 0xE9, 0x20, 0xD1);
            WPD_PROPERTY_SMS_MESSAGE_TYPE.pid = 1002;

            WPD_PROPERTY_SMS_TEXT_MESSAGE.fmtid = new Guid(0xAFC25D66, 0xFE0D, 0x4114, 0x90, 0x97, 0x97, 0x0C, 0x93, 0xE9, 0x20, 0xD1);
            WPD_PROPERTY_SMS_TEXT_MESSAGE.pid = 1003;

            WPD_PROPERTY_SMS_BINARY_MESSAGE.fmtid = new Guid(0xAFC25D66, 0xFE0D, 0x4114, 0x90, 0x97, 0x97, 0x0C, 0x93, 0xE9, 0x20, 0xD1);
            WPD_PROPERTY_SMS_BINARY_MESSAGE.pid = 1004;

            WPD_OPTION_SMS_BINARY_MESSAGE_SUPPORTED.fmtid = new Guid(0xAFC25D66, 0xFE0D, 0x4114, 0x90, 0x97, 0x97, 0x0C, 0x93, 0xE9, 0x20, 0xD1);
            WPD_OPTION_SMS_BINARY_MESSAGE_SUPPORTED.pid = 5001;

            WPD_COMMAND_STILL_IMAGE_CAPTURE_INITIATE.fmtid = new Guid(0x4FCD6982, 0x22A2, 0x4B05, 0xA4, 0x8B, 0x62, 0xD3, 0x8B, 0xF2, 0x7B, 0x32);
            WPD_COMMAND_STILL_IMAGE_CAPTURE_INITIATE.pid = 2;

            WPD_COMMAND_MEDIA_CAPTURE_START.fmtid = new Guid(0x59B433BA, 0xFE44, 0x4D8D, 0x80, 0x8C, 0x6B, 0xCB, 0x9B, 0x0F, 0x15, 0xE8);
            WPD_COMMAND_MEDIA_CAPTURE_START.pid = 2;

            WPD_COMMAND_MEDIA_CAPTURE_STOP.fmtid = new Guid(0x59B433BA, 0xFE44, 0x4D8D, 0x80, 0x8C, 0x6B, 0xCB, 0x9B, 0x0F, 0x15, 0xE8);
            WPD_COMMAND_MEDIA_CAPTURE_STOP.pid = 3;

            WPD_COMMAND_MEDIA_CAPTURE_PAUSE.fmtid = new Guid(0x59B433BA, 0xFE44, 0x4D8D, 0x80, 0x8C, 0x6B, 0xCB, 0x9B, 0x0F, 0x15, 0xE8);
            WPD_COMMAND_MEDIA_CAPTURE_PAUSE.pid = 4;

            WPD_COMMAND_DEVICE_HINTS_GET_CONTENT_LOCATION.fmtid = new Guid(0x0D5FB92B, 0xCB46, 0x4C4F, 0x83, 0x43, 0x0B, 0xC3, 0xD3, 0xF1, 0x7C, 0x84);
            WPD_COMMAND_DEVICE_HINTS_GET_CONTENT_LOCATION.pid = 2;

            WPD_PROPERTY_DEVICE_HINTS_CONTENT_TYPE.fmtid = new Guid(0x0D5FB92B, 0xCB46, 0x4C4F, 0x83, 0x43, 0x0B, 0xC3, 0xD3, 0xF1, 0x7C, 0x84);
            WPD_PROPERTY_DEVICE_HINTS_CONTENT_TYPE.pid = 1001;

            WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS.fmtid = new Guid(0x0D5FB92B, 0xCB46, 0x4C4F, 0x83, 0x43, 0x0B, 0xC3, 0xD3, 0xF1, 0x7C, 0x84);
            WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS.pid = 1002;

            WPD_COMMAND_CLASS_EXTENSION_WRITE_DEVICE_INFORMATION.fmtid = new Guid(0x33FB0D11, 0x64A3, 0x4FAC, 0xB4, 0xC7, 0x3D, 0xFE, 0xAA, 0x99, 0xB0, 0x51);
            WPD_COMMAND_CLASS_EXTENSION_WRITE_DEVICE_INFORMATION.pid = 2;

            WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_VALUES.fmtid = new Guid(0x33FB0D11, 0x64A3, 0x4FAC, 0xB4, 0xC7, 0x3D, 0xFE, 0xAA, 0x99, 0xB0, 0x51);
            WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_VALUES.pid = 1001;

            WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS.fmtid = new Guid(0x33FB0D11, 0x64A3, 0x4FAC, 0xB4, 0xC7, 0x3D, 0xFE, 0xAA, 0x99, 0xB0, 0x51);
            WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS.pid = 1002;

            WPD_COMMAND_GENERATE_KEYPAIR.fmtid = new Guid(0x78F9C6FC, 0x79B8, 0x473C, 0x90, 0x60, 0x6B, 0xD2, 0x3D, 0xD0, 0x72, 0xC4);
            WPD_COMMAND_GENERATE_KEYPAIR.pid = 2;

            WPD_COMMAND_COMMIT_KEYPAIR.fmtid = new Guid(0x78F9C6FC, 0x79B8, 0x473C, 0x90, 0x60, 0x6B, 0xD2, 0x3D, 0xD0, 0x72, 0xC4);
            WPD_COMMAND_COMMIT_KEYPAIR.pid = 3;

            WPD_COMMAND_PROCESS_WIRELESS_PROFILE.fmtid = new Guid(0x78F9C6FC, 0x79B8, 0x473C, 0x90, 0x60, 0x6B, 0xD2, 0x3D, 0xD0, 0x72, 0xC4);
            WPD_COMMAND_PROCESS_WIRELESS_PROFILE.pid = 4;

            WPD_PROPERTY_PUBLIC_KEY.fmtid = new Guid(0x78F9C6FC, 0x79B8, 0x473C, 0x90, 0x60, 0x6B, 0xD2, 0x3D, 0xD0, 0x72, 0xC4);
            WPD_PROPERTY_PUBLIC_KEY.pid = 1001;
        }

        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_DEFAULT;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_CONTACT_PHOTO;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_THUMBNAIL;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ICON;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_AUDIO_CLIP;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ALBUM_ART;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_GENERIC;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_VIDEO_CLIP;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_BRANDING_ART;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_NULL;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_PARENT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_PERSISTENT_UNIQUE_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_FORMAT;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_CONTENT_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_ISHIDDEN;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_ISSYSTEM;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_ORIGINAL_FILE_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_NON_CONSUMABLE;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_REFERENCES;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_KEYWORDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_SYNC_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_IS_DRM_PROTECTED;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_DATE_CREATED;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_DATE_MODIFIED;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_DATE_AUTHORED;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_BACK_REFERENCES;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_CONTAINER_FUNCTIONAL_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_GENERATE_THUMBNAIL_FROM_RESOURCE;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_HINT_LOCATION_DISPLAY_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_OBJECT_CAN_DELETE;
        public static PortableDeviceApiLib._tagpropertykey WPD_FUNCTIONAL_OBJECT_CATEGORY;
        public static PortableDeviceApiLib._tagpropertykey WPD_FOLDER_CONTENT_TYPES_ALLOWED;
        public static PortableDeviceApiLib._tagpropertykey WPD_IMAGE_BITDEPTH;
        public static PortableDeviceApiLib._tagpropertykey WPD_IMAGE_CROPPED_STATUS;
        public static PortableDeviceApiLib._tagpropertykey WPD_IMAGE_COLOR_CORRECTED_STATUS;
        public static PortableDeviceApiLib._tagpropertykey WPD_IMAGE_FNUMBER;
        public static PortableDeviceApiLib._tagpropertykey WPD_IMAGE_EXPOSURE_TIME;
        public static PortableDeviceApiLib._tagpropertykey WPD_IMAGE_EXPOSURE_INDEX;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_TOTAL_BITRATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_BITRATE_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_COPYRIGHT;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_SUBSCRIPTION_CONTENT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_USE_COUNT;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_SKIP_COUNT;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_LAST_ACCESSED_TIME;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_PARENTAL_RATING;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_META_GENRE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_COMPOSER;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_EFFECTIVE_RATING;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_SUB_TITLE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_RELEASE_DATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_SAMPLE_RATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_STAR_RATING;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_USER_EFFECTIVE_RATING;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_TITLE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_DURATION;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_BUY_NOW;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_ENCODING_PROFILE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_WIDTH;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_HEIGHT;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_ARTIST;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_ALBUM_ARTIST;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_OWNER;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_MANAGING_EDITOR;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_WEBMASTER;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_SOURCE_URL;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_DESTINATION_URL;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_DESCRIPTION;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_GENRE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_TIME_BOOKMARK;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_OBJECT_BOOKMARK;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_LAST_BUILD_DATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_BYTE_BOOKMARK;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_TIME_TO_LIVE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_GUID;
        public static PortableDeviceApiLib._tagpropertykey WPD_MEDIA_SUB_DESCRIPTION;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_DISPLAY_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_FIRST_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_MIDDLE_NAMES;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_LAST_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PREFIX;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_SUFFIX;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PHONETIC_FIRST_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PHONETIC_LAST_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_FULL_POSTAL_ADDRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE1;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_LINE2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_CITY;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_REGION;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_POSTAL_CODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_POSTAL_ADDRESS_COUNTRY;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_FULL_POSTAL_ADDRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE1;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_LINE2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_CITY;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_REGION;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_POSTAL_CODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_POSTAL_ADDRESS_COUNTRY;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_FULL_POSTAL_ADDRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE1;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_POSTAL_ADDRESS_LINE2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_POSTAL_ADDRESS_CITY;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_POSTAL_ADDRESS_REGION;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_CODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_POSTAL_ADDRESS_POSTAL_COUNTRY;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PRIMARY_EMAIL_ADDRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_EMAIL;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_EMAIL2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_EMAIL;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_EMAIL2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_EMAILS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PRIMARY_PHONE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_PHONE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_PHONE2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_PHONE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_PHONE2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_MOBILE_PHONE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_MOBILE_PHONE2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_FAX;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_FAX;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PAGER;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_OTHER_PHONES;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PRIMARY_WEB_ADDRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PERSONAL_WEB_ADDRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BUSINESS_WEB_ADDRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_INSTANT_MESSENGER;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_INSTANT_MESSENGER2;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_INSTANT_MESSENGER3;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_COMPANY_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PHONETIC_COMPANY_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_ROLE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_BIRTHDATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_PRIMARY_FAX;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_SPOUSE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_CHILDREN;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_ASSISTANT;
        public static PortableDeviceApiLib._tagpropertykey WPD_CONTACT_ANNIVERSARY_DATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_MUSIC_ALBUM;
        public static PortableDeviceApiLib._tagpropertykey WPD_MUSIC_TRACK;
        public static PortableDeviceApiLib._tagpropertykey WPD_MUSIC_LYRICS;
        public static PortableDeviceApiLib._tagpropertykey WPD_MUSIC_MOOD;
        public static PortableDeviceApiLib._tagpropertykey WPD_AUDIO_BITRATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_AUDIO_CHANNEL_COUNT;
        public static PortableDeviceApiLib._tagpropertykey WPD_AUDIO_FORMAT_CODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_AUDIO_BIT_DEPTH;
        public static PortableDeviceApiLib._tagpropertykey WPD_AUDIO_BLOCK_ALIGNMENT;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_AUTHOR;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_RECORDEDTV_STATION_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_RECORDEDTV_CHANNEL_NUMBER;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_RECORDEDTV_REPEAT;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_BUFFER_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_CREDITS;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_KEY_FRAME_DISTANCE;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_QUALITY_SETTING;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_SCAN_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_BITRATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_FOURCC_CODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_VIDEO_FRAMERATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMON_INFORMATION_SUBJECT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMON_INFORMATION_BODY_TEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMON_INFORMATION_PRIORITY;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMON_INFORMATION_START_DATETIME;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMON_INFORMATION_END_DATETIME;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMON_INFORMATION_NOTES;
        public static PortableDeviceApiLib._tagpropertykey WPD_EMAIL_TO_LINE;
        public static PortableDeviceApiLib._tagpropertykey WPD_EMAIL_CC_LINE;
        public static PortableDeviceApiLib._tagpropertykey WPD_EMAIL_BCC_LINE;
        public static PortableDeviceApiLib._tagpropertykey WPD_EMAIL_HAS_BEEN_READ;
        public static PortableDeviceApiLib._tagpropertykey WPD_EMAIL_RECEIVED_TIME;
        public static PortableDeviceApiLib._tagpropertykey WPD_EMAIL_HAS_ATTACHMENTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_EMAIL_SENDER_ADDRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_APPOINTMENT_LOCATION;
        public static PortableDeviceApiLib._tagpropertykey WPD_APPOINTMENT_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_APPOINTMENT_REQUIRED_ATTENDEES;
        public static PortableDeviceApiLib._tagpropertykey WPD_APPOINTMENT_OPTIONAL_ATTENDEES;
        public static PortableDeviceApiLib._tagpropertykey WPD_APPOINTMENT_ACCEPTED_ATTENDEES;
        public static PortableDeviceApiLib._tagpropertykey WPD_APPOINTMENT_RESOURCES;
        public static PortableDeviceApiLib._tagpropertykey WPD_APPOINTMENT_TENTATIVE_ATTENDEES;
        public static PortableDeviceApiLib._tagpropertykey WPD_APPOINTMENT_DECLINED_ATTENDEES;
        public static PortableDeviceApiLib._tagpropertykey WPD_TASK_STATUS;
        public static PortableDeviceApiLib._tagpropertykey WPD_TASK_PERCENT_COMPLETE;
        public static PortableDeviceApiLib._tagpropertykey WPD_TASK_REMINDER_DATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_TASK_OWNER;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_FILE_SYSTEM_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_CAPACITY;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_FREE_SPACE_IN_BYTES;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_FREE_SPACE_IN_OBJECTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_DESCRIPTION;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_SERIAL_NUMBER;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_MAX_OBJECT_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_CAPACITY_IN_OBJECTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_STORAGE_ACCESS_CAPABILITY;
        public static PortableDeviceApiLib._tagpropertykey WPD_NETWORK_ASSOCIATION_HOST_NETWORK_IDENTIFIERS;
        public static PortableDeviceApiLib._tagpropertykey WPD_NETWORK_ASSOCIATION_X509V3SEQUENCE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_CAPTURE_RESOLUTION;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_CAPTURE_FORMAT;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_COMPRESSION_SETTING;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_WHITE_BALANCE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_RGB_GAIN;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_FNUMBER;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_FOCAL_LENGTH;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_FOCUS_DISTANCE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_FOCUS_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_EXPOSURE_METERING_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_FLASH_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_EXPOSURE_TIME;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_EXPOSURE_PROGRAM_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_EXPOSURE_INDEX;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_EXPOSURE_BIAS_COMPENSATION;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_CAPTURE_DELAY;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_CAPTURE_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_CONTRAST;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_SHARPNESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_DIGITAL_ZOOM;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_EFFECT_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_BURST_NUMBER;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_BURST_INTERVAL;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_TIMELAPSE_NUMBER;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_TIMELAPSE_INTERVAL;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_FOCUS_METERING_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_UPLOAD_URL;
        public static PortableDeviceApiLib._tagpropertykey WPD_STILL_IMAGE_ARTIST;
        public static PortableDeviceApiLib._tagpropertykey WPD_SMS_PROVIDER;
        public static PortableDeviceApiLib._tagpropertykey WPD_SMS_TIMEOUT;
        public static PortableDeviceApiLib._tagpropertykey WPD_SMS_MAX_PAYLOAD;
        public static PortableDeviceApiLib._tagpropertykey WPD_SMS_ENCODING;
        public static PortableDeviceApiLib._tagpropertykey WPD_SECTION_DATA_OFFSET;
        public static PortableDeviceApiLib._tagpropertykey WPD_SECTION_DATA_LENGTH;
        public static PortableDeviceApiLib._tagpropertykey WPD_SECTION_DATA_UNITS;
        public static PortableDeviceApiLib._tagpropertykey WPD_SECTION_DATA_REFERENCED_OBJECT_RESOURCE;
        public static PortableDeviceApiLib._tagpropertykey WPD_RENDERING_INFORMATION_PROFILES;
        public static PortableDeviceApiLib._tagpropertykey WPD_RENDERING_INFORMATION_PROFILE_ENTRY_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_RENDERING_INFORMATION_PROFILE_ENTRY_CREATABLE_RESOURCES;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_MAJOR_VERSION;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_MINOR_VERSION;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_REVISION;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_WMDRM_APPLICATION_PRIVATE_KEY;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_WMDRM_APPLICATION_CERTIFICATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_SECURITY_QUALITY_OF_SERVICE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_DESIRED_ACCESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_SHARE_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLIENT_EVENT_COOKIE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_FORM;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_CAN_READ;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_CAN_WRITE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_CAN_DELETE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_DEFAULT_VALUE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_FAST_PROPERTY;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_RANGE_MIN;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_RANGE_MAX;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_RANGE_STEP;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_ENUMERATION_ELEMENTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_REGULAR_EXPRESSION;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_ATTRIBUTE_MAX_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLASS_EXTENSION_OPTIONS_SUPPORTED_CONTENT_TYPES;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLASS_EXTENSION_OPTIONS_DONT_REGISTER_WPD_DEVICE_INTERFACE;
        public static PortableDeviceApiLib._tagpropertykey WPD_CLASS_EXTENSION_OPTIONS_REGISTER_WPD_PRIVATE_DEVICE_INTERFACE;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ATTRIBUTE_TOTAL_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ATTRIBUTE_CAN_READ;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ATTRIBUTE_CAN_WRITE;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ATTRIBUTE_CAN_DELETE;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ATTRIBUTE_OPTIMAL_READ_BUFFER_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ATTRIBUTE_OPTIMAL_WRITE_BUFFER_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ATTRIBUTE_FORMAT;
        public static PortableDeviceApiLib._tagpropertykey WPD_RESOURCE_ATTRIBUTE_RESOURCE_KEY;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_SYNC_PARTNER;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_FIRMWARE_VERSION;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_POWER_LEVEL;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_POWER_SOURCE;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_PROTOCOL;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_MANUFACTURER;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_MODEL;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_SERIAL_NUMBER;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_SUPPORTS_NON_CONSUMABLE;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_DATETIME;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_FRIENDLY_NAME;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_SUPPORTED_DRM_SCHEMES;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_SUPPORTED_FORMATS_ARE_ORDERED;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_DEVICE_NETWORK_IDENTIFIER;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_PARAMETER_PNP_DEVICE_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_PARAMETER_EVENT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_PARAMETER_OPERATION_STATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_PARAMETER_OPERATION_PROGRESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_PARAMETER_OBJECT_PARENT_PERSISTENT_UNIQUE_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_PARAMETER_OBJECT_CREATION_COOKIE;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_PARAMETER_CHILD_HIERARCHY_CHANGED;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_OPTION_IS_BROADCAST_EVENT;
        public static PortableDeviceApiLib._tagpropertykey WPD_EVENT_OPTION_IS_AUTOPLAY_EVENT;
        public static PortableDeviceApiLib._tagpropertykey WPD_API_OPTION_USE_CLEAR_DATA_STREAM;
        public static PortableDeviceApiLib._tagpropertykey WPD_API_OPTION_IOCTL_ACCESS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_COMMON_RESET_DEVICE;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_COMMON_GET_OBJECT_IDS_FROM_PERSISTENT_UNIQUE_IDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_COMMON_SAVE_CLIENT_INFORMATION;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_COMMAND_CATEGORY;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_COMMAND_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_HRESULT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_DRIVER_ERROR_CODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_COMMAND_TARGET;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_PERSISTENT_UNIQUE_IDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_OBJECT_IDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_CLIENT_INFORMATION;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_COMMON_CLIENT_INFORMATION_CONTEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_OPTION_VALID_OBJECT_IDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_ENUMERATION_START_FIND;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_ENUMERATION_FIND_NEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_ENUMERATION_END_FIND;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_ENUMERATION_PARENT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_ENUMERATION_FILTER;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_ENUMERATION_OBJECT_IDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_ENUMERATION_CONTEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_ENUMERATION_NUM_OBJECTS_REQUESTED;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_GET_SUPPORTED;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_GET_ATTRIBUTES;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_GET;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_SET;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_GET_ALL;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_DELETE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_KEYS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_ATTRIBUTES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_VALUES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_PROPERTY_WRITE_RESULTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_START;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_NEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_LIST_END;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_START;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_NEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_GET_VALUES_BY_OBJECT_FORMAT_END;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_START;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_NEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_PROPERTIES_BULK_SET_VALUES_BY_OBJECT_LIST_END;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_IDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_BULK_CONTEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_BULK_VALUES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PROPERTY_KEYS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_BULK_DEPTH;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_BULK_PARENT_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_BULK_OBJECT_FORMAT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_PROPERTIES_BULK_WRITE_RESULTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_GET_SUPPORTED;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_GET_ATTRIBUTES;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_OPEN;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_READ;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_WRITE;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_CLOSE;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_DELETE;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_CREATE_RESOURCE;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_REVERT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_RESOURCES_SEEK;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_ACCESS_MODE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_KEYS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_RESOURCE_ATTRIBUTES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_CONTEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_READ;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_READ;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_TO_WRITE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_NUM_BYTES_WRITTEN;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_DATA;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_OPTIMAL_TRANSFER_BUFFER_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_SEEK_OFFSET;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_SEEK_ORIGIN_FLAG;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_RESOURCES_POSITION_FROM_START;
        public static PortableDeviceApiLib._tagpropertykey WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_READ_SUPPORTED;
        public static PortableDeviceApiLib._tagpropertykey WPD_OPTION_OBJECT_RESOURCES_SEEK_ON_WRITE_SUPPORTED;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_ONLY;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_MANAGEMENT_CREATE_OBJECT_WITH_PROPERTIES_AND_DATA;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_MANAGEMENT_WRITE_OBJECT_DATA;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_MANAGEMENT_COMMIT_OBJECT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_MANAGEMENT_REVERT_OBJECT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_MANAGEMENT_DELETE_OBJECTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_MANAGEMENT_MOVE_OBJECTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_OBJECT_MANAGEMENT_COPY_OBJECTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_CREATION_PROPERTIES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_CONTEXT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_TO_WRITE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_NUM_BYTES_WRITTEN;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_DATA;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_OPTIONS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_OPTIMAL_TRANSFER_BUFFER_SIZE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_OBJECT_IDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_DELETE_RESULTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_DESTINATION_FOLDER_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_MOVE_RESULTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_OBJECT_MANAGEMENT_COPY_RESULTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_OPTION_OBJECT_MANAGEMENT_RECURSIVE_DELETE_SUPPORTED;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_COMMANDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_COMMAND_OPTIONS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FUNCTIONAL_CATEGORIES;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_FUNCTIONAL_OBJECTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_CONTENT_TYPES;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMATS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_FORMAT_PROPERTIES;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_FIXED_PROPERTY_ATTRIBUTES;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_SUPPORTED_EVENTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CAPABILITIES_GET_EVENT_OPTIONS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_SUPPORTED_COMMANDS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_COMMAND;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_COMMAND_OPTIONS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORIES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_CATEGORY;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_FUNCTIONAL_OBJECTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_CONTENT_TYPES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_CONTENT_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_FORMATS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_FORMAT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_PROPERTY_KEYS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_PROPERTY_ATTRIBUTES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_SUPPORTED_EVENTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_EVENT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CAPABILITIES_EVENT_OPTIONS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_STORAGE_FORMAT;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_STORAGE_EJECT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_STORAGE_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_STORAGE_DESTINATION_OBJECT_ID;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_SMS_SEND;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_SMS_RECIPIENT;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_SMS_MESSAGE_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_SMS_TEXT_MESSAGE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_SMS_BINARY_MESSAGE;
        public static PortableDeviceApiLib._tagpropertykey WPD_OPTION_SMS_BINARY_MESSAGE_SUPPORTED;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_STILL_IMAGE_CAPTURE_INITIATE;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_MEDIA_CAPTURE_START;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_MEDIA_CAPTURE_STOP;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_MEDIA_CAPTURE_PAUSE;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_DEVICE_HINTS_GET_CONTENT_LOCATION;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_DEVICE_HINTS_CONTENT_TYPE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_DEVICE_HINTS_CONTENT_LOCATIONS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_CLASS_EXTENSION_WRITE_DEVICE_INFORMATION;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_VALUES;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_CLASS_EXTENSION_DEVICE_INFORMATION_WRITE_RESULTS;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_GENERATE_KEYPAIR;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_COMMIT_KEYPAIR;
        public static PortableDeviceApiLib._tagpropertykey WPD_COMMAND_PROCESS_WIRELESS_PROFILE;
        public static PortableDeviceApiLib._tagpropertykey WPD_PROPERTY_PUBLIC_KEY;
    }


}
