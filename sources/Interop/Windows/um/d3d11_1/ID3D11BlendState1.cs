// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CC86FABE-DA55-401D-85E7-E3C9DE2877E9")]
    public unsafe partial struct ID3D11BlendState1
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID3D11BlendState1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID3D11BlendState1*, uint>)(lpVtbl[1]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID3D11BlendState1*, uint>)(lpVtbl[2]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this));
        }

        public void GetDevice([NativeTypeName("ID3D11Device **")] ID3D11Device** ppDevice)
        {
            ((delegate* stdcall<ID3D11BlendState1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT *")] uint* pDataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11BlendState1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("UINT")] uint DataSize, [NativeTypeName("const void *")] void* pData)
        {
            return ((delegate* stdcall<ID3D11BlendState1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
        {
            return ((delegate* stdcall<ID3D11BlendState1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this), guid, pData);
        }

        public void GetDesc([NativeTypeName("D3D11_BLEND_DESC *")] D3D11_BLEND_DESC* pDesc)
        {
            ((delegate* stdcall<ID3D11BlendState1*, D3D11_BLEND_DESC*, void>)(lpVtbl[7]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this), pDesc);
        }

        public void GetDesc1([NativeTypeName("D3D11_BLEND_DESC1 *")] D3D11_BLEND_DESC1* pDesc)
        {
            ((delegate* stdcall<ID3D11BlendState1*, D3D11_BLEND_DESC1*, void>)(lpVtbl[8]))((ID3D11BlendState1*)Unsafe.AsPointer(ref this), pDesc);
        }
    }
}
