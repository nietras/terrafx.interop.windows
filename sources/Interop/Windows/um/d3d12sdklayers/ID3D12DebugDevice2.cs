// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("60ECCBC1-378D-4DF1-894C-F8AC5CE4D7DD")]
    public unsafe partial struct ID3D12DebugDevice2
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D12DebugDevice2*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D12DebugDevice2*, uint>)(lpVtbl[1]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D12DebugDevice2*, uint>)(lpVtbl[2]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFeatureMask(D3D12_DEBUG_FEATURE Mask)
        {
            return ((delegate* stdcall<ID3D12DebugDevice2*, D3D12_DEBUG_FEATURE, int>)(lpVtbl[3]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Mask);
        }

        public D3D12_DEBUG_FEATURE GetFeatureMask()
        {
            return ((delegate* stdcall<ID3D12DebugDevice2*, D3D12_DEBUG_FEATURE>)(lpVtbl[4]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ReportLiveDeviceObjects(D3D12_RLDO_FLAGS Flags)
        {
            return ((delegate* stdcall<ID3D12DebugDevice2*, D3D12_RLDO_FLAGS, int>)(lpVtbl[5]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, [NativeTypeName("const void *")] void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            return ((delegate* stdcall<ID3D12DebugDevice2*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[6]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDebugParameter(D3D12_DEBUG_DEVICE_PARAMETER_TYPE Type, [NativeTypeName("void *")] void* pData, [NativeTypeName("UINT")] uint DataSize)
        {
            return ((delegate* stdcall<ID3D12DebugDevice2*, D3D12_DEBUG_DEVICE_PARAMETER_TYPE, void*, uint, int>)(lpVtbl[7]))((ID3D12DebugDevice2*)Unsafe.AsPointer(ref this), Type, pData, DataSize);
        }
    }
}
