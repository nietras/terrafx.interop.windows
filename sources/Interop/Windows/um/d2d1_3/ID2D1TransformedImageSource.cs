// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7F1F79E5-2796-416C-8F55-700F911445E5")]
    public unsafe partial struct ID2D1TransformedImageSource
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1TransformedImageSource*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1TransformedImageSource*, uint>)(lpVtbl[1]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1TransformedImageSource*, uint>)(lpVtbl[2]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1TransformedImageSource*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), factory);
        }

        public void GetSource([NativeTypeName("ID2D1ImageSource **")] ID2D1ImageSource** imageSource)
        {
            ((delegate* stdcall<ID2D1TransformedImageSource*, ID2D1ImageSource**, void>)(lpVtbl[4]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), imageSource);
        }

        public void GetProperties([NativeTypeName("D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES *")] D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES* properties)
        {
            ((delegate* stdcall<ID2D1TransformedImageSource*, D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES*, void>)(lpVtbl[5]))((ID2D1TransformedImageSource*)Unsafe.AsPointer(ref this), properties);
        }
    }
}
