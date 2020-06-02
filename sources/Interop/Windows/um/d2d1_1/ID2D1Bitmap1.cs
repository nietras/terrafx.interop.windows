// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A898A84C-3873-4588-B08B-EBBF978DF041")]
    public unsafe partial struct ID2D1Bitmap1
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            lpVtbl->GetFactory((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("D2D1_SIZE_F")]
        public D2D_SIZE_F GetSize()
        {
            D2D_SIZE_F result;
            return *lpVtbl->GetSize((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        [return: NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U GetPixelSize()
        {
            D2D_SIZE_U result;
            return *lpVtbl->GetPixelSize((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        public D2D1_PIXEL_FORMAT GetPixelFormat()
        {
            D2D1_PIXEL_FORMAT result;
            return *lpVtbl->GetPixelFormat((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), &result);
        }

        public void GetDpi([NativeTypeName("FLOAT *")] float* dpiX, [NativeTypeName("FLOAT *")] float* dpiY)
        {
            lpVtbl->GetDpi((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dpiX, dpiY);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromBitmap([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1Bitmap *")] ID2D1Bitmap* bitmap, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
        {
            return lpVtbl->CopyFromBitmap((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, bitmap, srcRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromRenderTarget([NativeTypeName("const D2D1_POINT_2U *")] D2D_POINT_2U* destPoint, [NativeTypeName("ID2D1RenderTarget *")] ID2D1RenderTarget* renderTarget, [NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* srcRect)
        {
            return lpVtbl->CopyFromRenderTarget((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), destPoint, renderTarget, srcRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int CopyFromMemory([NativeTypeName("const D2D1_RECT_U *")] D2D_RECT_U* dstRect, [NativeTypeName("const void *")] void* srcData, [NativeTypeName("UINT32")] uint pitch)
        {
            return lpVtbl->CopyFromMemory((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dstRect, srcData, pitch);
        }

        public void GetColorContext([NativeTypeName("ID2D1ColorContext **")] ID2D1ColorContext** colorContext)
        {
            lpVtbl->GetColorContext((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), colorContext);
        }

        public D2D1_BITMAP_OPTIONS GetOptions()
        {
            return lpVtbl->GetOptions((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSurface([NativeTypeName("IDXGISurface **")] IDXGISurface** dxgiSurface)
        {
            return lpVtbl->GetSurface((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), dxgiSurface);
        }

        [return: NativeTypeName("HRESULT")]
        public int Map(D2D1_MAP_OPTIONS options, [NativeTypeName("D2D1_MAPPED_RECT *")] D2D1_MAPPED_RECT* mappedRect)
        {
            return lpVtbl->Map((ID2D1Bitmap1*)Unsafe.AsPointer(ref this), options, mappedRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unmap()
        {
            return lpVtbl->Unmap((ID2D1Bitmap1*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, D2D_SIZE_F*, D2D_SIZE_F*> GetSize;

            [NativeTypeName("D2D1_SIZE_U () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, D2D_SIZE_U*, D2D_SIZE_U*> GetPixelSize;

            [NativeTypeName("D2D1_PIXEL_FORMAT () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, D2D1_PIXEL_FORMAT*, D2D1_PIXEL_FORMAT*> GetPixelFormat;

            [NativeTypeName("void (FLOAT *, FLOAT *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, float*, float*, void> GetDpi;

            [NativeTypeName("HRESULT (const D2D1_POINT_2U *, ID2D1Bitmap *, const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, D2D_POINT_2U*, ID2D1Bitmap*, D2D_RECT_U*, int> CopyFromBitmap;

            [NativeTypeName("HRESULT (const D2D1_POINT_2U *, ID2D1RenderTarget *, const D2D1_RECT_U *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, D2D_POINT_2U*, ID2D1RenderTarget*, D2D_RECT_U*, int> CopyFromRenderTarget;

            [NativeTypeName("HRESULT (const D2D1_RECT_U *, const void *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, D2D_RECT_U*, void*, uint, int> CopyFromMemory;

            [NativeTypeName("void (ID2D1ColorContext **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, ID2D1ColorContext**, void> GetColorContext;

            [NativeTypeName("D2D1_BITMAP_OPTIONS () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, D2D1_BITMAP_OPTIONS> GetOptions;

            [NativeTypeName("HRESULT (IDXGISurface **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, IDXGISurface**, int> GetSurface;

            [NativeTypeName("HRESULT (D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, D2D1_MAP_OPTIONS, D2D1_MAPPED_RECT*, int> Map;

            [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<ID2D1Bitmap1*, int> Unmap;
        }
    }
}
