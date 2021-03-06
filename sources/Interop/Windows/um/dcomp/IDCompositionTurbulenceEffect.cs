// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6A55BDA-C09C-49F3-9193-A41922C89715")]
    public unsafe partial struct IDCompositionTurbulenceEffect
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, uint>)(lpVtbl[1]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, uint>)(lpVtbl[2]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInput([NativeTypeName("UINT")] uint index, [NativeTypeName("IUnknown *")] IUnknown* input, [NativeTypeName("UINT")] uint flags)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, uint, IUnknown*, uint, int>)(lpVtbl[3]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), index, input, flags);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOffset([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* offset)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[4]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), offset);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetBaseFrequency([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* frequency)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[5]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), frequency);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSize([NativeTypeName("const D2D1_VECTOR_2F &")] D2D_VECTOR_2F* size)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, D2D_VECTOR_2F*, int>)(lpVtbl[6]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), size);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNumOctaves([NativeTypeName("UINT")] uint numOctaves)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, uint, int>)(lpVtbl[7]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), numOctaves);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetSeed([NativeTypeName("UINT")] uint seed)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, uint, int>)(lpVtbl[8]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), seed);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetNoise(D2D1_TURBULENCE_NOISE noise)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, D2D1_TURBULENCE_NOISE, int>)(lpVtbl[9]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), noise);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStitchable([NativeTypeName("BOOL")] int stitchable)
        {
            return ((delegate* stdcall<IDCompositionTurbulenceEffect*, int, int>)(lpVtbl[10]))((IDCompositionTurbulenceEffect*)Unsafe.AsPointer(ref this), stitchable);
        }
    }
}
