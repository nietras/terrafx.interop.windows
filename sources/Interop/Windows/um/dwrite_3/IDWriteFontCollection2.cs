// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("514039C6-4617-4064-BF8B-92EA83E506E0")]
    public unsafe partial struct IDWriteFontCollection2
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyCount()
        {
            return lpVtbl->GetFontFamilyCount((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily **")] IDWriteFontFamily** fontFamily)
        {
            return lpVtbl->GetFontFamily((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [return: NativeTypeName("HRESULT")]
        public int FindFamilyName([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("UINT32 *")] uint* index, [NativeTypeName("BOOL *")] int* exists)
        {
            return lpVtbl->FindFamilyName((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), familyName, index, exists);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFromFontFace([NativeTypeName("IDWriteFontFace *")] IDWriteFontFace* fontFace, [NativeTypeName("IDWriteFont **")] IDWriteFont** font)
        {
            return lpVtbl->GetFontFromFontFace((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontFace, font);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSet([NativeTypeName("IDWriteFontSet **")] IDWriteFontSet** fontSet)
        {
            return lpVtbl->GetFontSet((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontSet);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily1 **")] IDWriteFontFamily1** fontFamily)
        {
            return lpVtbl->GetFontFamily1((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamily([NativeTypeName("UINT32")] uint index, [NativeTypeName("IDWriteFontFamily2 **")] IDWriteFontFamily2** fontFamily)
        {
            return lpVtbl->GetFontFamily2((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), index, fontFamily);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMatchingFonts([NativeTypeName("const WCHAR *")] ushort* familyName, [NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount, [NativeTypeName("IDWriteFontList2 **")] IDWriteFontList2** fontList)
        {
            return lpVtbl->GetMatchingFonts((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), familyName, fontAxisValues, fontAxisValueCount, fontList);
        }

        public DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel()
        {
            return lpVtbl->GetFontFamilyModel((IDWriteFontCollection2*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSet([NativeTypeName("IDWriteFontSet1 **")] IDWriteFontSet1** fontSet)
        {
            return lpVtbl->GetFontSet1((IDWriteFontCollection2*)Unsafe.AsPointer(ref this), fontSet);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, uint> Release;

            [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, uint> GetFontFamilyCount;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, uint, IDWriteFontFamily**, int> GetFontFamily;

            [NativeTypeName("HRESULT (const WCHAR *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, ushort*, uint*, int*, int> FindFamilyName;

            [NativeTypeName("HRESULT (IDWriteFontFace *, IDWriteFont **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, IDWriteFontFace*, IDWriteFont**, int> GetFontFromFontFace;

            [NativeTypeName("HRESULT (IDWriteFontSet **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, IDWriteFontSet**, int> GetFontSet;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, uint, IDWriteFontFamily1**, int> GetFontFamily1;

            [NativeTypeName("HRESULT (UINT32, IDWriteFontFamily2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, uint, IDWriteFontFamily2**, int> GetFontFamily2;

            [NativeTypeName("HRESULT (const WCHAR *, const DWRITE_FONT_AXIS_VALUE *, UINT32, IDWriteFontList2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, ushort*, DWRITE_FONT_AXIS_VALUE*, uint, IDWriteFontList2**, int> GetMatchingFonts;

            [NativeTypeName("DWRITE_FONT_FAMILY_MODEL () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, DWRITE_FONT_FAMILY_MODEL> GetFontFamilyModel;

            [NativeTypeName("HRESULT (IDWriteFontSet1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* stdcall<IDWriteFontCollection2*, IDWriteFontSet1**, int> GetFontSet1;
        }
    }
}
