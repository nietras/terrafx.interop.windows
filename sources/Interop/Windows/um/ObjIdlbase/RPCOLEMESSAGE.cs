// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct RPCOLEMESSAGE
    {
        [NativeTypeName("void *")]
        public void* reserved1;

        [NativeTypeName("RPCOLEDATAREP")]
        public uint dataRepresentation;

        [NativeTypeName("void *")]
        public void* Buffer;

        [NativeTypeName("ULONG")]
        public uint cbBuffer;

        [NativeTypeName("ULONG")]
        public uint iMethod;

        [NativeTypeName("void *[5]")]
        public _reserved2_e__FixedBuffer reserved2;

        [NativeTypeName("ULONG")]
        public uint rpcFlags;

        public partial struct _reserved2_e__FixedBuffer
        {
            internal IntPtr e0;
            internal IntPtr e1;
            internal IntPtr e2;
            internal IntPtr e3;
            internal IntPtr e4;

            public ref IntPtr this[int index] => ref AsSpan()[index];

            public Span<IntPtr> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 5);
        }
    }
}
