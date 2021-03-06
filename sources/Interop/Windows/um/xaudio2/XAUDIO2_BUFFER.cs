// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct XAUDIO2_BUFFER
    {
        [NativeTypeName("UINT32")]
        public uint Flags;

        [NativeTypeName("UINT32")]
        public uint AudioBytes;

        [NativeTypeName("const BYTE *")]
        public byte* pAudioData;

        [NativeTypeName("UINT32")]
        public uint PlayBegin;

        [NativeTypeName("UINT32")]
        public uint PlayLength;

        [NativeTypeName("UINT32")]
        public uint LoopBegin;

        [NativeTypeName("UINT32")]
        public uint LoopLength;

        [NativeTypeName("UINT32")]
        public uint LoopCount;

        [NativeTypeName("void *")]
        public void* pContext;
    }
}
