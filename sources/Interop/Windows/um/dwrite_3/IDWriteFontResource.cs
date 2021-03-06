// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1F803A76-6871-48E8-987F-B975551C50F2")]
    public unsafe partial struct IDWriteFontResource
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontResource*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontResource*, uint>)(lpVtbl[1]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontResource*, uint>)(lpVtbl[2]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFile([NativeTypeName("IDWriteFontFile **")] IDWriteFontFile** fontFile)
        {
            return ((delegate* stdcall<IDWriteFontResource*, IDWriteFontFile**, int>)(lpVtbl[3]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontFile);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFaceIndex()
        {
            return ((delegate* stdcall<IDWriteFontResource*, uint>)(lpVtbl[4]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontAxisCount()
        {
            return ((delegate* stdcall<IDWriteFontResource*, uint>)(lpVtbl[5]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFontAxisValues([NativeTypeName("DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
        {
            return ((delegate* stdcall<IDWriteFontResource*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[6]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontAxisRanges([NativeTypeName("DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRanges, [NativeTypeName("UINT32")] uint fontAxisRangeCount)
        {
            return ((delegate* stdcall<IDWriteFontResource*, DWRITE_FONT_AXIS_RANGE*, uint, int>)(lpVtbl[7]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontAxisRanges, fontAxisRangeCount);
        }

        public DWRITE_FONT_AXIS_ATTRIBUTES GetFontAxisAttributes([NativeTypeName("UINT32")] uint axisIndex)
        {
            return ((delegate* stdcall<IDWriteFontResource*, uint, DWRITE_FONT_AXIS_ATTRIBUTES>)(lpVtbl[8]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAxisNames([NativeTypeName("UINT32")] uint axisIndex, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return ((delegate* stdcall<IDWriteFontResource*, uint, IDWriteLocalizedStrings**, int>)(lpVtbl[9]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, names);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetAxisValueNameCount([NativeTypeName("UINT32")] uint axisIndex)
        {
            return ((delegate* stdcall<IDWriteFontResource*, uint, uint>)(lpVtbl[10]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAxisValueNames([NativeTypeName("UINT32")] uint axisIndex, [NativeTypeName("UINT32")] uint axisValueIndex, [NativeTypeName("DWRITE_FONT_AXIS_RANGE *")] DWRITE_FONT_AXIS_RANGE* fontAxisRange, [NativeTypeName("IDWriteLocalizedStrings **")] IDWriteLocalizedStrings** names)
        {
            return ((delegate* stdcall<IDWriteFontResource*, uint, uint, DWRITE_FONT_AXIS_RANGE*, IDWriteLocalizedStrings**, int>)(lpVtbl[11]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), axisIndex, axisValueIndex, fontAxisRange, names);
        }

        [return: NativeTypeName("BOOL")]
        public int HasVariations()
        {
            return ((delegate* stdcall<IDWriteFontResource*, int>)(lpVtbl[12]))((IDWriteFontResource*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFace(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontFace5 **")] IDWriteFontFace5** fontFace)
        {
            return ((delegate* stdcall<IDWriteFontResource*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFace5**, int>)(lpVtbl[13]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFace);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFontFaceReference(DWRITE_FONT_SIMULATIONS fontSimulations, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontFaceReference1 **")] IDWriteFontFaceReference1** fontFaceReference)
        {
            return ((delegate* stdcall<IDWriteFontResource*, DWRITE_FONT_SIMULATIONS, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontFaceReference1**, int>)(lpVtbl[14]))((IDWriteFontResource*)Unsafe.AsPointer(ref this), fontSimulations, fontAxisValues, fontAxisValueCount, fontFaceReference);
        }
    }
}
