// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7B7166EC-21C7-44AE-B21A-C9AE321AE369")]
    public unsafe partial struct IDXGIFactory
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXGIFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXGIFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXGIFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return lpVtbl->SetPrivateData((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return lpVtbl->SetPrivateDataInterface((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return lpVtbl->GetPrivateData((IDXGIFactory*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return lpVtbl->GetParent((IDXGIFactory*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return lpVtbl->EnumAdapters((IDXGIFactory*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags)
        {
            return lpVtbl->MakeWindowAssociation((IDXGIFactory*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation([NativeTypeName("HWND *")] IntPtr* pWindowHandle)
        {
            return lpVtbl->GetWindowAssociation((IDXGIFactory*)Unsafe.AsPointer(ref this), pWindowHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain)
        {
            return lpVtbl->CreateSwapChain((IDXGIFactory*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter([NativeTypeName("HMODULE")] IntPtr Module, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return lpVtbl->CreateSoftwareAdapter((IDXGIFactory*)Unsafe.AsPointer(ref this), Module, ppAdapter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, Guid*, void**, int> GetParent;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, uint, IDXGIAdapter**, int> EnumAdapters;

            [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, IntPtr, uint, int> MakeWindowAssociation;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, IntPtr*, int> GetWindowAssociation;

            [NativeTypeName("HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, IUnknown*, DXGI_SWAP_CHAIN_DESC*, IDXGISwapChain**, int> CreateSwapChain;

            [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXGIFactory*, IntPtr, IDXGIAdapter**, int> CreateSoftwareAdapter;
        }
    }
}
