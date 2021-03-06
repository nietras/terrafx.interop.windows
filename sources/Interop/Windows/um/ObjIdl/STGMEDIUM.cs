// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct STGMEDIUM
    {
        [NativeTypeName("DWORD")]
        public uint tymed;

        [NativeTypeName("tagSTGMEDIUM::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/ObjIdl.h:11272:36)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("IUnknown *")]
        public IUnknown* pUnkForRelease;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hBitmap;

            [FieldOffset(0)]
            [NativeTypeName("HMETAFILEPICT")]
            public void* hMetaFilePict;

            [FieldOffset(0)]
            [NativeTypeName("HENHMETAFILE")]
            public IntPtr hEnhMetaFile;

            [FieldOffset(0)]
            [NativeTypeName("HGLOBAL")]
            public IntPtr hGlobal;

            [FieldOffset(0)]
            [NativeTypeName("LPOLESTR")]
            public ushort* lpszFileName;

            [FieldOffset(0)]
            [NativeTypeName("IStream *")]
            public IStream* pstm;

            [FieldOffset(0)]
            [NativeTypeName("IStorage *")]
            public IStorage* pstg;
        }
    }
}
