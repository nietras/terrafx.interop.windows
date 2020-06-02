// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FC4801A3-2BA9-11CF-A229-00AA003D7352")]
    public unsafe partial struct IObjectWithSite
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IObjectWithSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IObjectWithSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IObjectWithSite*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSite([NativeTypeName("IUnknown *")] IUnknown* pUnkSite)
        {
            return lpVtbl->SetSite((IObjectWithSite*)Unsafe.AsPointer(ref this), pUnkSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSite([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvSite)
        {
            return lpVtbl->GetSite((IObjectWithSite*)Unsafe.AsPointer(ref this), riid, ppvSite);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IObjectWithSite*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IObjectWithSite*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IObjectWithSite*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IObjectWithSite*, IUnknown*, int> SetSite;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IObjectWithSite*, Guid*, void**, int> GetSite;
        }
    }
}
