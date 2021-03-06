// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0E6D4D92-6738-11CF-9608-00AA00680DB4")]
    public unsafe partial struct IDirectWriterLock
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDirectWriterLock*, Guid*, void**, int>)(lpVtbl[0]))((IDirectWriterLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDirectWriterLock*, uint>)(lpVtbl[1]))((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDirectWriterLock*, uint>)(lpVtbl[2]))((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int WaitForWriteAccess([NativeTypeName("DWORD")] uint dwTimeout)
        {
            return ((delegate* stdcall<IDirectWriterLock*, uint, int>)(lpVtbl[3]))((IDirectWriterLock*)Unsafe.AsPointer(ref this), dwTimeout);
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseWriteAccess()
        {
            return ((delegate* stdcall<IDirectWriterLock*, int>)(lpVtbl[4]))((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int HaveWriteAccess()
        {
            return ((delegate* stdcall<IDirectWriterLock*, int>)(lpVtbl[5]))((IDirectWriterLock*)Unsafe.AsPointer(ref this));
        }
    }
}
