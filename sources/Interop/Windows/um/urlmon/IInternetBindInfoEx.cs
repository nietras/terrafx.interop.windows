// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A3E015B7-A82C-4DCD-A150-569AEEED36AB")]
    public unsafe partial struct IInternetBindInfoEx
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IInternetBindInfoEx*, Guid*, void**, int>)(lpVtbl[0]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IInternetBindInfoEx*, uint>)(lpVtbl[1]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IInternetBindInfoEx*, uint>)(lpVtbl[2]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindInfo([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo)
        {
            return ((delegate* stdcall<IInternetBindInfoEx*, uint*, BINDINFO*, int>)(lpVtbl[3]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindString([NativeTypeName("ULONG")] uint ulStringType, [NativeTypeName("LPOLESTR *")] ushort** ppwzStr, [NativeTypeName("ULONG")] uint cEl, [NativeTypeName("ULONG *")] uint* pcElFetched)
        {
            return ((delegate* stdcall<IInternetBindInfoEx*, uint, ushort**, uint, uint*, int>)(lpVtbl[4]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), ulStringType, ppwzStr, cEl, pcElFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetBindInfoEx([NativeTypeName("DWORD *")] uint* grfBINDF, [NativeTypeName("BINDINFO *")] BINDINFO* pbindinfo, [NativeTypeName("DWORD *")] uint* grfBINDF2, [NativeTypeName("DWORD *")] uint* pdwReserved)
        {
            return ((delegate* stdcall<IInternetBindInfoEx*, uint*, BINDINFO*, uint*, uint*, int>)(lpVtbl[5]))((IInternetBindInfoEx*)Unsafe.AsPointer(ref this), grfBINDF, pbindinfo, grfBINDF2, pdwReserved);
        }
    }
}
