// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C1B6694F-FF09-44A9-B03C-77900A0A1D17")]
    public unsafe partial struct IDXGIFactory6
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXGIFactory6* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXGIFactory6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXGIFactory6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(IDXGIFactory6* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(IDXGIFactory6* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(IDXGIFactory6* pThis, [NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(IDXGIFactory6* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters(IDXGIFactory6* pThis, [NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MakeWindowAssociation(IDXGIFactory6* pThis, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetWindowAssociation(IDXGIFactory6* pThis, [NativeTypeName("HWND *")] IntPtr* pWindowHandle);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChain(IDXGIFactory6* pThis, [NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSoftwareAdapter(IDXGIFactory6* pThis, [NativeTypeName("HMODULE")] IntPtr Module, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapters1(IDXGIFactory6* pThis, [NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter1 **")] IDXGIAdapter1** ppAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsCurrent(IDXGIFactory6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("BOOL")]
        public delegate int _IsWindowedStereoEnabled(IDXGIFactory6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForHwnd(IDXGIFactory6* pThis, [NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForCoreWindow(IDXGIFactory6* pThis, [NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IUnknown *")] IUnknown* pWindow, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSharedResourceAdapterLuid(IDXGIFactory6* pThis, [NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("LUID *")] LUID* pLuid);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterStereoStatusWindow(IDXGIFactory6* pThis, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterStereoStatusEvent(IDXGIFactory6* pThis, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterStereoStatus(IDXGIFactory6* pThis, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterOcclusionStatusWindow(IDXGIFactory6* pThis, [NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _RegisterOcclusionStatusEvent(IDXGIFactory6* pThis, [NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _UnregisterOcclusionStatus(IDXGIFactory6* pThis, [NativeTypeName("DWORD")] uint dwCookie);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateSwapChainForComposition(IDXGIFactory6* pThis, [NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT")]
        public delegate uint _GetCreationFlags(IDXGIFactory6* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapterByLuid(IDXGIFactory6* pThis, LUID AdapterLuid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumWarpAdapter(IDXGIFactory6* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CheckFeatureSupport(IDXGIFactory6* pThis, DXGI_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdapterByGpuPreference(IDXGIFactory6* pThis, [NativeTypeName("UINT")] uint Adapter, DXGI_GPU_PREFERENCE GpuPreference, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXGIFactory6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXGIFactory6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXGIFactory6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)((IDXGIFactory6*)Unsafe.AsPointer(ref this), Name, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("const IUnknown *")] IUnknown* pUnknown)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)((IDXGIFactory6*)Unsafe.AsPointer(ref this), Name, pUnknown);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* Name, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)((IDXGIFactory6*)Unsafe.AsPointer(ref this), Name, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppParent)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)((IDXGIFactory6*)Unsafe.AsPointer(ref this), riid, ppParent);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumAdapters>(lpVtbl->EnumAdapters)((IDXGIFactory6*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int MakeWindowAssociation([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint Flags)
        {
            return Marshal.GetDelegateForFunctionPointer<_MakeWindowAssociation>(lpVtbl->MakeWindowAssociation)((IDXGIFactory6*)Unsafe.AsPointer(ref this), WindowHandle, Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetWindowAssociation([NativeTypeName("HWND *")] IntPtr* pWindowHandle)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetWindowAssociation>(lpVtbl->GetWindowAssociation)((IDXGIFactory6*)Unsafe.AsPointer(ref this), pWindowHandle);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChain([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("DXGI_SWAP_CHAIN_DESC *")] DXGI_SWAP_CHAIN_DESC* pDesc, [NativeTypeName("IDXGISwapChain **")] IDXGISwapChain** ppSwapChain)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSwapChain>(lpVtbl->CreateSwapChain)((IDXGIFactory6*)Unsafe.AsPointer(ref this), pDevice, pDesc, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSoftwareAdapter([NativeTypeName("HMODULE")] IntPtr Module, [NativeTypeName("IDXGIAdapter **")] IDXGIAdapter** ppAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSoftwareAdapter>(lpVtbl->CreateSoftwareAdapter)((IDXGIFactory6*)Unsafe.AsPointer(ref this), Module, ppAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapters1([NativeTypeName("UINT")] uint Adapter, [NativeTypeName("IDXGIAdapter1 **")] IDXGIAdapter1** ppAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumAdapters1>(lpVtbl->EnumAdapters1)((IDXGIFactory6*)Unsafe.AsPointer(ref this), Adapter, ppAdapter);
        }

        [return: NativeTypeName("BOOL")]
        public int IsCurrent()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsCurrent>(lpVtbl->IsCurrent)((IDXGIFactory6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int IsWindowedStereoEnabled()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsWindowedStereoEnabled>(lpVtbl->IsWindowedStereoEnabled)((IDXGIFactory6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForHwnd([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("HWND")] IntPtr hWnd, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *")] DXGI_SWAP_CHAIN_FULLSCREEN_DESC* pFullscreenDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForHwnd>(lpVtbl->CreateSwapChainForHwnd)((IDXGIFactory6*)Unsafe.AsPointer(ref this), pDevice, hWnd, pDesc, pFullscreenDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForCoreWindow([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("IUnknown *")] IUnknown* pWindow, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForCoreWindow>(lpVtbl->CreateSwapChainForCoreWindow)((IDXGIFactory6*)Unsafe.AsPointer(ref this), pDevice, pWindow, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSharedResourceAdapterLuid([NativeTypeName("HANDLE")] IntPtr hResource, [NativeTypeName("LUID *")] LUID* pLuid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSharedResourceAdapterLuid>(lpVtbl->GetSharedResourceAdapterLuid)((IDXGIFactory6*)Unsafe.AsPointer(ref this), hResource, pLuid);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterStereoStatusWindow>(lpVtbl->RegisterStereoStatusWindow)((IDXGIFactory6*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterStereoStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterStereoStatusEvent>(lpVtbl->RegisterStereoStatusEvent)((IDXGIFactory6*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterStereoStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            Marshal.GetDelegateForFunctionPointer<_UnregisterStereoStatus>(lpVtbl->UnregisterStereoStatus)((IDXGIFactory6*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusWindow([NativeTypeName("HWND")] IntPtr WindowHandle, [NativeTypeName("UINT")] uint wMsg, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterOcclusionStatusWindow>(lpVtbl->RegisterOcclusionStatusWindow)((IDXGIFactory6*)Unsafe.AsPointer(ref this), WindowHandle, wMsg, pdwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int RegisterOcclusionStatusEvent([NativeTypeName("HANDLE")] IntPtr hEvent, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return Marshal.GetDelegateForFunctionPointer<_RegisterOcclusionStatusEvent>(lpVtbl->RegisterOcclusionStatusEvent)((IDXGIFactory6*)Unsafe.AsPointer(ref this), hEvent, pdwCookie);
        }

        public void UnregisterOcclusionStatus([NativeTypeName("DWORD")] uint dwCookie)
        {
            Marshal.GetDelegateForFunctionPointer<_UnregisterOcclusionStatus>(lpVtbl->UnregisterOcclusionStatus)((IDXGIFactory6*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateSwapChainForComposition([NativeTypeName("IUnknown *")] IUnknown* pDevice, [NativeTypeName("const DXGI_SWAP_CHAIN_DESC1 *")] DXGI_SWAP_CHAIN_DESC1* pDesc, [NativeTypeName("IDXGIOutput *")] IDXGIOutput* pRestrictToOutput, [NativeTypeName("IDXGISwapChain1 **")] IDXGISwapChain1** ppSwapChain)
        {
            return Marshal.GetDelegateForFunctionPointer<_CreateSwapChainForComposition>(lpVtbl->CreateSwapChainForComposition)((IDXGIFactory6*)Unsafe.AsPointer(ref this), pDevice, pDesc, pRestrictToOutput, ppSwapChain);
        }

        [return: NativeTypeName("UINT")]
        public uint GetCreationFlags()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetCreationFlags>(lpVtbl->GetCreationFlags)((IDXGIFactory6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterByLuid(LUID AdapterLuid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumAdapterByLuid>(lpVtbl->EnumAdapterByLuid)((IDXGIFactory6*)Unsafe.AsPointer(ref this), AdapterLuid, riid, ppvAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumWarpAdapter([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumWarpAdapter>(lpVtbl->EnumWarpAdapter)((IDXGIFactory6*)Unsafe.AsPointer(ref this), riid, ppvAdapter);
        }

        [return: NativeTypeName("HRESULT")]
        public int CheckFeatureSupport(DXGI_FEATURE Feature, [NativeTypeName("void *")] void* pFeatureSupportData, [NativeTypeName("UINT")] uint FeatureSupportDataSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_CheckFeatureSupport>(lpVtbl->CheckFeatureSupport)((IDXGIFactory6*)Unsafe.AsPointer(ref this), Feature, pFeatureSupportData, FeatureSupportDataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdapterByGpuPreference([NativeTypeName("UINT")] uint Adapter, DXGI_GPU_PREFERENCE GpuPreference, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumAdapterByGpuPreference>(lpVtbl->EnumAdapterByGpuPreference)((IDXGIFactory6*)Unsafe.AsPointer(ref this), Adapter, GpuPreference, riid, ppvAdapter);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
            public IntPtr SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
            public IntPtr SetPrivateDataInterface;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
            public IntPtr GetPrivateData;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetParent;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter **) __attribute__((stdcall))")]
            public IntPtr EnumAdapters;

            [NativeTypeName("HRESULT (HWND, UINT) __attribute__((stdcall))")]
            public IntPtr MakeWindowAssociation;

            [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
            public IntPtr GetWindowAssociation;

            [NativeTypeName("HRESULT (IUnknown *, DXGI_SWAP_CHAIN_DESC *, IDXGISwapChain **) __attribute__((stdcall))")]
            public IntPtr CreateSwapChain;

            [NativeTypeName("HRESULT (HMODULE, IDXGIAdapter **) __attribute__((stdcall))")]
            public IntPtr CreateSoftwareAdapter;

            [NativeTypeName("HRESULT (UINT, IDXGIAdapter1 **) __attribute__((stdcall))")]
            public IntPtr EnumAdapters1;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr IsCurrent;

            [NativeTypeName("BOOL () __attribute__((stdcall))")]
            public IntPtr IsWindowedStereoEnabled;

            [NativeTypeName("HRESULT (IUnknown *, HWND, const DXGI_SWAP_CHAIN_DESC1 *, const DXGI_SWAP_CHAIN_FULLSCREEN_DESC *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
            public IntPtr CreateSwapChainForHwnd;

            [NativeTypeName("HRESULT (IUnknown *, IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
            public IntPtr CreateSwapChainForCoreWindow;

            [NativeTypeName("HRESULT (HANDLE, LUID *) __attribute__((stdcall))")]
            public IntPtr GetSharedResourceAdapterLuid;

            [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
            public IntPtr RegisterStereoStatusWindow;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public IntPtr RegisterStereoStatusEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public IntPtr UnregisterStereoStatus;

            [NativeTypeName("HRESULT (HWND, UINT, DWORD *) __attribute__((stdcall))")]
            public IntPtr RegisterOcclusionStatusWindow;

            [NativeTypeName("HRESULT (HANDLE, DWORD *) __attribute__((stdcall))")]
            public IntPtr RegisterOcclusionStatusEvent;

            [NativeTypeName("void (DWORD) __attribute__((stdcall))")]
            public IntPtr UnregisterOcclusionStatus;

            [NativeTypeName("HRESULT (IUnknown *, const DXGI_SWAP_CHAIN_DESC1 *, IDXGIOutput *, IDXGISwapChain1 **) __attribute__((stdcall))")]
            public IntPtr CreateSwapChainForComposition;

            [NativeTypeName("UINT () __attribute__((stdcall))")]
            public IntPtr GetCreationFlags;

            [NativeTypeName("HRESULT (LUID, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr EnumAdapterByLuid;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr EnumWarpAdapter;

            [NativeTypeName("HRESULT (DXGI_FEATURE, void *, UINT) __attribute__((stdcall))")]
            public IntPtr CheckFeatureSupport;

            [NativeTypeName("HRESULT (UINT, DXGI_GPU_PREFERENCE, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr EnumAdapterByGpuPreference;
        }
    }
}