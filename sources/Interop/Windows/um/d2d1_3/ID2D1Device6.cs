// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7BFEF914-2D75-4BAD-BE87-E18DDB077B6D")]
    public unsafe partial struct ID2D1Device6
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1Device6*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Device6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1Device6*, uint>)(lpVtbl[1]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1Device6*, uint>)(lpVtbl[2]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1Device6*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Device6*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext **")] ID2D1DeviceContext** deviceContext)
        {
            return ((delegate* stdcall<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext**, int>)(lpVtbl[4]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePrintControl([NativeTypeName("IWICImagingFactory *")] IWICImagingFactory* wicFactory, [NativeTypeName("IPrintDocumentPackageTarget *")] IPrintDocumentPackageTarget* documentTarget, [NativeTypeName("const D2D1_PRINT_CONTROL_PROPERTIES *")] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, [NativeTypeName("ID2D1PrintControl **")] ID2D1PrintControl** printControl)
        {
            return ((delegate* stdcall<ID2D1Device6*, IWICImagingFactory*, IPrintDocumentPackageTarget*, D2D1_PRINT_CONTROL_PROPERTIES*, ID2D1PrintControl**, int>)(lpVtbl[5]))((ID2D1Device6*)Unsafe.AsPointer(ref this), wicFactory, documentTarget, printControlProperties, printControl);
        }

        public void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            ((delegate* stdcall<ID2D1Device6*, ulong, void>)(lpVtbl[6]))((ID2D1Device6*)Unsafe.AsPointer(ref this), maximumInBytes);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            return ((delegate* stdcall<ID2D1Device6*, ulong>)(lpVtbl[7]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
        {
            ((delegate* stdcall<ID2D1Device6*, uint, void>)(lpVtbl[8]))((ID2D1Device6*)Unsafe.AsPointer(ref this), millisecondsSinceUse);
        }

        public D2D1_RENDERING_PRIORITY GetRenderingPriority()
        {
            return ((delegate* stdcall<ID2D1Device6*, D2D1_RENDERING_PRIORITY>)(lpVtbl[9]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        public void SetRenderingPriority(D2D1_RENDERING_PRIORITY renderingPriority)
        {
            ((delegate* stdcall<ID2D1Device6*, D2D1_RENDERING_PRIORITY, void>)(lpVtbl[10]))((ID2D1Device6*)Unsafe.AsPointer(ref this), renderingPriority);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext1 **")] ID2D1DeviceContext1** deviceContext1)
        {
            return ((delegate* stdcall<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext1**, int>)(lpVtbl[11]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext1);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext2 **")] ID2D1DeviceContext2** deviceContext2)
        {
            return ((delegate* stdcall<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext2**, int>)(lpVtbl[12]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext2);
        }

        public void FlushDeviceContexts([NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap)
        {
            ((delegate* stdcall<ID2D1Device6*, ID2D1Bitmap*, void>)(lpVtbl[13]))((ID2D1Device6*)Unsafe.AsPointer(ref this), bitmap);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDxgiDevice([NativeTypeName("IDXGIDevice **")] IDXGIDevice** dxgiDevice)
        {
            return ((delegate* stdcall<ID2D1Device6*, IDXGIDevice**, int>)(lpVtbl[14]))((ID2D1Device6*)Unsafe.AsPointer(ref this), dxgiDevice);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext3 **")] ID2D1DeviceContext3** deviceContext3)
        {
            return ((delegate* stdcall<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext3**, int>)(lpVtbl[15]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext3);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext4 **")] ID2D1DeviceContext4** deviceContext4)
        {
            return ((delegate* stdcall<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext4**, int>)(lpVtbl[16]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext4);
        }

        public void SetMaximumColorGlyphCacheMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            ((delegate* stdcall<ID2D1Device6*, ulong, void>)(lpVtbl[17]))((ID2D1Device6*)Unsafe.AsPointer(ref this), maximumInBytes);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumColorGlyphCacheMemory()
        {
            return ((delegate* stdcall<ID2D1Device6*, ulong>)(lpVtbl[18]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext5 **")] ID2D1DeviceContext5** deviceContext5)
        {
            return ((delegate* stdcall<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext5**, int>)(lpVtbl[19]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext5);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext6 **")] ID2D1DeviceContext6** deviceContext6)
        {
            return ((delegate* stdcall<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext6**, int>)(lpVtbl[20]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext6);
        }
    }
}
