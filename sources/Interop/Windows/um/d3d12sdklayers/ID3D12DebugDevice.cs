// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3FEBD6DD-4973-4787-8194-E45F9E28923E")]
    public unsafe struct ID3D12DebugDevice
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID3D12DebugDevice* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID3D12DebugDevice* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID3D12DebugDevice* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFeatureMask(
            [In] ID3D12DebugDevice* This,
            [In] D3D12_DEBUG_FEATURE Mask
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_DEBUG_FEATURE _GetFeatureMask(
            [In] ID3D12DebugDevice* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReportLiveDeviceObjects(
            [In] ID3D12DebugDevice* This,
            [In] D3D12_RLDO_FLAGS Flags
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12DebugDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID3D12DebugDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12DebugDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask(
            [In] D3D12_DEBUG_FEATURE Mask
        )
        {
            fixed (ID3D12DebugDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFeatureMask>(lpVtbl->SetFeatureMask)(
                    This,
                    Mask
                );
            }
        }

        public D3D12_DEBUG_FEATURE GetFeatureMask()
        {
            fixed (ID3D12DebugDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFeatureMask>(lpVtbl->GetFeatureMask)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveDeviceObjects(
            [In] D3D12_RLDO_FLAGS Flags
        )
        {
            fixed (ID3D12DebugDevice* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReportLiveDeviceObjects>(lpVtbl->ReportLiveDeviceObjects)(
                    This,
                    Flags
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetFeatureMask;

            public IntPtr GetFeatureMask;

            public IntPtr ReportLiveDeviceObjects;
        }
    }
}
