// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SP_FILE_COPY_PARAMS_W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HSPFILEQ")]
        public void* QueueHandle;

        [NativeTypeName("PCWSTR")]
        public ushort* SourceRootPath;

        [NativeTypeName("PCWSTR")]
        public ushort* SourcePath;

        [NativeTypeName("PCWSTR")]
        public ushort* SourceFilename;

        [NativeTypeName("PCWSTR")]
        public ushort* SourceDescription;

        [NativeTypeName("PCWSTR")]
        public ushort* SourceTagfile;

        [NativeTypeName("PCWSTR")]
        public ushort* TargetDirectory;

        [NativeTypeName("PCWSTR")]
        public ushort* TargetFilename;

        [NativeTypeName("DWORD")]
        public uint CopyStyle;

        [NativeTypeName("HINF")]
        public void* LayoutInf;

        [NativeTypeName("PCWSTR")]
        public ushort* SecurityDescriptor;
    }
}
