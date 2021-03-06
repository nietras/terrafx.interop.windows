// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct IMAGE_HOT_PATCH_BASE
    {
        [NativeTypeName("DWORD")]
        public uint SequenceNumber;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint OriginalTimeDateStamp;

        [NativeTypeName("DWORD")]
        public uint OriginalCheckSum;

        [NativeTypeName("DWORD")]
        public uint CodeIntegrityInfo;

        [NativeTypeName("DWORD")]
        public uint CodeIntegritySize;

        [NativeTypeName("DWORD")]
        public uint PatchTable;

        [NativeTypeName("DWORD")]
        public uint BufferOffset;
    }
}
