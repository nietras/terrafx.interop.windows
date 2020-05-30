// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WAVEHDR
    {
        [NativeTypeName("LPSTR")]
        public sbyte* lpData;

        [NativeTypeName("DWORD")]
        public uint dwBufferLength;

        [NativeTypeName("DWORD")]
        public uint dwBytesRecorded;

        [NativeTypeName("DWORD_PTR")]
        public nuint dwUser;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint dwLoops;

        [NativeTypeName("struct wavehdr_tag *")]
        public WAVEHDR* lpNext;

        [NativeTypeName("DWORD_PTR")]
        public nuint reserved;
    }
}
