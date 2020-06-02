// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("102CA951-311B-4B01-B11F-ECB83E061B37")]
    public unsafe partial struct ID3D12DebugCommandList1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("BOOL")]
        public int AssertResourceState([NativeTypeName("ID3D12Resource *")] ID3D12Resource* pResource, [NativeTypeName("UINT")] uint Subresource, [NativeTypeName("UINT")] uint State)
        {
            return lpVtbl->AssertResourceState((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            return lpVtbl->SetDebugParameter((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDebugParameter(D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE Type, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            return lpVtbl->GetDebugParameter((ID3D12DebugCommandList1*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DebugCommandList1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DebugCommandList1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DebugCommandList1*, uint> Release;

            [NativeTypeName("BOOL (ID3D12Resource *, UINT, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DebugCommandList1*, ID3D12Resource*, uint, uint, int> AssertResourceState;

            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, const void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DebugCommandList1*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int> SetDebugParameter;

            [NativeTypeName("HRESULT (D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void *, UINT) __attribute__((stdcall))")]
            public delegate* stdcall<ID3D12DebugCommandList1*, D3D12_DEBUG_COMMAND_LIST_PARAMETER_TYPE, void*, uint, int> GetDebugParameter;
        }
    }
}
