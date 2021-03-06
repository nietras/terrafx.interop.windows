// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020402-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeLib
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ITypeLib*, Guid*, void**, int>)(lpVtbl[0]))((ITypeLib*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ITypeLib*, uint>)(lpVtbl[1]))((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ITypeLib*, uint>)(lpVtbl[2]))((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT")]
        public uint GetTypeInfoCount()
        {
            return ((delegate* stdcall<ITypeLib*, uint>)(lpVtbl[3]))((ITypeLib*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint index, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ITypeLib*, uint, ITypeInfo**, int>)(lpVtbl[4]))((ITypeLib*)Unsafe.AsPointer(ref this), index, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoType([NativeTypeName("UINT")] uint index, [NativeTypeName("TYPEKIND *")] TYPEKIND* pTKind)
        {
            return ((delegate* stdcall<ITypeLib*, uint, TYPEKIND*, int>)(lpVtbl[5]))((ITypeLib*)Unsafe.AsPointer(ref this), index, pTKind);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoOfGuid([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTinfo)
        {
            return ((delegate* stdcall<ITypeLib*, Guid*, ITypeInfo**, int>)(lpVtbl[6]))((ITypeLib*)Unsafe.AsPointer(ref this), guid, ppTinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLibAttr([NativeTypeName("TLIBATTR **")] TLIBATTR** ppTLibAttr)
        {
            return ((delegate* stdcall<ITypeLib*, TLIBATTR**, int>)(lpVtbl[7]))((ITypeLib*)Unsafe.AsPointer(ref this), ppTLibAttr);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeComp([NativeTypeName("ITypeComp **")] ITypeComp** ppTComp)
        {
            return ((delegate* stdcall<ITypeLib*, ITypeComp**, int>)(lpVtbl[8]))((ITypeLib*)Unsafe.AsPointer(ref this), ppTComp);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDocumentation([NativeTypeName("INT")] int index, [NativeTypeName("BSTR *")] ushort** pBstrName, [NativeTypeName("BSTR *")] ushort** pBstrDocString, [NativeTypeName("DWORD *")] uint* pdwHelpContext, [NativeTypeName("BSTR *")] ushort** pBstrHelpFile)
        {
            return ((delegate* stdcall<ITypeLib*, int, ushort**, ushort**, uint*, ushort**, int>)(lpVtbl[9]))((ITypeLib*)Unsafe.AsPointer(ref this), index, pBstrName, pBstrDocString, pdwHelpContext, pBstrHelpFile);
        }

        [return: NativeTypeName("HRESULT")]
        public int IsName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("BOOL *")] int* pfName)
        {
            return ((delegate* stdcall<ITypeLib*, ushort*, uint, int*, int>)(lpVtbl[10]))((ITypeLib*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, pfName);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindName([NativeTypeName("LPOLESTR")] ushort* szNameBuf, [NativeTypeName("ULONG")] uint lHashVal, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo, [NativeTypeName("MEMBERID *")] int* rgMemId, [NativeTypeName("USHORT *")] ushort* pcFound)
        {
            return ((delegate* stdcall<ITypeLib*, ushort*, uint, ITypeInfo**, int*, ushort*, int>)(lpVtbl[11]))((ITypeLib*)Unsafe.AsPointer(ref this), szNameBuf, lHashVal, ppTInfo, rgMemId, pcFound);
        }

        public void ReleaseTLibAttr([NativeTypeName("TLIBATTR *")] TLIBATTR* pTLibAttr)
        {
            ((delegate* stdcall<ITypeLib*, TLIBATTR*, void>)(lpVtbl[12]))((ITypeLib*)Unsafe.AsPointer(ref this), pTLibAttr);
        }
    }
}
