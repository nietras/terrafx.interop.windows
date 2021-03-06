// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const int MSSIP_FLAGS_PROHIBIT_RESIZE_ON_CREATE = 0x00010000;

        public const int MSSIP_FLAGS_USE_CATALOG = 0x00020000;

        public const int MSSIP_FLAGS_MULTI_HASH = 0x00040000;

        public const int SPC_INC_PE_RESOURCES_FLAG = 0x80;

        public const int SPC_INC_PE_DEBUG_INFO_FLAG = 0x40;

        public const int SPC_INC_PE_IMPORT_ADDR_TABLE_FLAG = 0x20;

        public const int SPC_EXC_PE_PAGE_HASHES_FLAG = 0x10;

        public const int SPC_INC_PE_PAGE_HASHES_FLAG = 0x100;

        public const int SPC_DIGEST_GENERATE_FLAG = 0x200;

        public const int SPC_DIGEST_SIGN_FLAG = 0x400;

        public const int SPC_RELAXED_PE_MARKER_CHECK = 0x800;

        public const int SPC_MARKER_CHECK_SKIP_SIP_INDIRECT_DATA_FLAG = 0x00000001;

        public const int MSSIP_ADDINFO_NONE = 0;

        public const int MSSIP_ADDINFO_FLAT = 1;

        public const int MSSIP_ADDINFO_CATMEMBER = 2;

        public const int MSSIP_ADDINFO_BLOB = 3;

        public const int MSSIP_ADDINFO_NONMSSIP = 500;

        public const int SIP_CAP_SET_VERSION_2 = 2;

        public const int SIP_CAP_SET_VERSION_3 = 3;

        public const int SIP_CAP_SET_CUR_VER = 3;

        public const int SIP_CAP_FLAG_SEALING = 0x00000001;

        public const int SIP_MAX_MAGIC_NUMBER = 4;

        public const int SPC_MARKER_CHECK_CURRENTLY_SUPPORTED_FLAGS = SPC_MARKER_CHECK_SKIP_SIP_INDIRECT_DATA_FLAG;
    }
}
