// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12sdklayers.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053F")]
    public unsafe struct ID3D12DebugCommandList
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID3D12DebugCommandList* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID3D12DebugCommandList* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID3D12DebugCommandList* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int _AssertResourceState(
            [In] ID3D12DebugCommandList* This,
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint Subresource,
            [In, NativeTypeName("UINT")] uint State
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetFeatureMask(
            [In] ID3D12DebugCommandList* This,
            [In] D3D12_DEBUG_FEATURE Mask
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D3D12_DEBUG_FEATURE _GetFeatureMask(
            [In] ID3D12DebugCommandList* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID3D12DebugCommandList* This = &this)
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
            fixed (ID3D12DebugCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID3D12DebugCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        public int AssertResourceState(
            [In] ID3D12Resource* pResource,
            [In, NativeTypeName("UINT")] uint Subresource,
            [In, NativeTypeName("UINT")] uint State
        )
        {
            fixed (ID3D12DebugCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AssertResourceState>(lpVtbl->AssertResourceState)(
                    This,
                    pResource,
                    Subresource,
                    State
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask(
            [In] D3D12_DEBUG_FEATURE Mask
        )
        {
            fixed (ID3D12DebugCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetFeatureMask>(lpVtbl->SetFeatureMask)(
                    This,
                    Mask
                );
            }
        }

        public D3D12_DEBUG_FEATURE GetFeatureMask()
        {
            fixed (ID3D12DebugCommandList* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFeatureMask>(lpVtbl->GetFeatureMask)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr AssertResourceState;

            public IntPtr SetFeatureMask;

            public IntPtr GetFeatureMask;
        }
    }
}
