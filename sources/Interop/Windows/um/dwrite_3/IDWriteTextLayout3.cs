// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("07DDCD52-020E-4DE8-AC33-6C953D83F92D")]
    public unsafe partial struct IDWriteTextLayout3
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint>)(lpVtbl[1]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint>)(lpVtbl[2]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), paragraphAlignment);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), wordWrapping);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), readingDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), flowDirection);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetIncrementalTabStop([NativeTypeName("FLOAT")] float incrementalTabStop)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float, int>)(lpVtbl[8]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), incrementalTabStop);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* trimmingSign)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, [NativeTypeName("FLOAT")] float lineSpacing, [NativeTypeName("FLOAT")] float baseline)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_WORD_WRAPPING GetWordWrapping()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_READING_DIRECTION GetReadingDirection()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FLOW_DIRECTION GetFlowDirection()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetIncrementalTabStop()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float>)(lpVtbl[16]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTrimming([NativeTypeName("DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** trimmingSign)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING_METHOD *")] DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, [NativeTypeName("FLOAT *")] float* lineSpacing, [NativeTypeName("FLOAT *")] float* baseline)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontCollection);
        }

        [return: NativeTypeName("UINT32")]
        public uint GetFontFamilyNameLength()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint>)(lpVtbl[20]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
        }

        public DWRITE_FONT_WEIGHT GetFontWeight()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STYLE GetFontStyle()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_FONT_STRETCH GetFontStretch()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetFontSize()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float>)(lpVtbl[25]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetLocaleNameLength()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint>)(lpVtbl[26]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), localeName, nameSize);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaxWidth([NativeTypeName("FLOAT")] float maxWidth)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float, int>)(lpVtbl[28]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), maxWidth);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMaxHeight([NativeTypeName("FLOAT")] float maxHeight)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float, int>)(lpVtbl[29]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), maxHeight);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontCollection([NativeTypeName("IDWriteFontCollection *")] IDWriteFontCollection* fontCollection, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, IDWriteFontCollection*, DWRITE_TEXT_RANGE, int>)(lpVtbl[30]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontCollection, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFamilyName([NativeTypeName("const WCHAR *")] ushort* fontFamilyName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[31]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFamilyName, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontWeight(DWRITE_FONT_WEIGHT fontWeight, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_FONT_WEIGHT, DWRITE_TEXT_RANGE, int>)(lpVtbl[32]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontWeight, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontStyle(DWRITE_FONT_STYLE fontStyle, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_FONT_STYLE, DWRITE_TEXT_RANGE, int>)(lpVtbl[33]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontStyle, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontStretch(DWRITE_FONT_STRETCH fontStretch, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_FONT_STRETCH, DWRITE_TEXT_RANGE, int>)(lpVtbl[34]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontStretch, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontSize([NativeTypeName("FLOAT")] float fontSize, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float, DWRITE_TEXT_RANGE, int>)(lpVtbl[35]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontSize, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetUnderline([NativeTypeName("BOOL")] int hasUnderline, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, int, DWRITE_TEXT_RANGE, int>)(lpVtbl[36]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), hasUnderline, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetStrikethrough([NativeTypeName("BOOL")] int hasStrikethrough, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, int, DWRITE_TEXT_RANGE, int>)(lpVtbl[37]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), hasStrikethrough, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetDrawingEffect([NativeTypeName("IUnknown *")] IUnknown* drawingEffect, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, IUnknown*, DWRITE_TEXT_RANGE, int>)(lpVtbl[38]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), drawingEffect, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetInlineObject([NativeTypeName("IDWriteInlineObject *")] IDWriteInlineObject* inlineObject, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, IDWriteInlineObject*, DWRITE_TEXT_RANGE, int>)(lpVtbl[39]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), inlineObject, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetTypography([NativeTypeName("IDWriteTypography *")] IDWriteTypography* typography, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, IDWriteTypography*, DWRITE_TEXT_RANGE, int>)(lpVtbl[40]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), typography, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLocaleName([NativeTypeName("const WCHAR *")] ushort* localeName, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, ushort*, DWRITE_TEXT_RANGE, int>)(lpVtbl[41]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), localeName, textRange);
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMaxWidth()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float>)(lpVtbl[42]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetMaxHeight()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float>)(lpVtbl[43]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontCollection([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteFontCollection **")] IDWriteFontCollection** fontCollection, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, IDWriteFontCollection**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[44]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontCollection, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[45]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFamilyName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[46]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontFamilyName, nameSize, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontWeight([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_WEIGHT *")] DWRITE_FONT_WEIGHT* fontWeight, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, DWRITE_FONT_WEIGHT*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[47]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontWeight, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStyle([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_STYLE *")] DWRITE_FONT_STYLE* fontStyle, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, DWRITE_FONT_STYLE*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[48]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontStyle, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontStretch([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("DWRITE_FONT_STRETCH *")] DWRITE_FONT_STRETCH* fontStretch, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, DWRITE_FONT_STRETCH*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[49]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontStretch, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontSize([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* fontSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, float*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[50]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, fontSize, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUnderline([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasUnderline, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, int*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[51]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, hasUnderline, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStrikethrough([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* hasStrikethrough, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, int*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[52]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, hasStrikethrough, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDrawingEffect([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IUnknown **")] IUnknown** drawingEffect, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, IUnknown**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[53]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, drawingEffect, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetInlineObject([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteInlineObject **")] IDWriteInlineObject** inlineObject, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, IDWriteInlineObject**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[54]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, inlineObject, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypography([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("IDWriteTypography **")] IDWriteTypography** typography, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, IDWriteTypography**, DWRITE_TEXT_RANGE*, int>)(lpVtbl[55]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, typography, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleNameLength([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("UINT32 *")] uint* nameLength, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, uint*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[56]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, nameLength, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLocaleName([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, ushort*, uint, DWRITE_TEXT_RANGE*, int>)(lpVtbl[57]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, localeName, nameSize, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int Draw([NativeTypeName("void *")] void* clientDrawingContext, [NativeTypeName("IDWriteTextRenderer *")] IDWriteTextRenderer* renderer, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, void*, IDWriteTextRenderer*, float, float, int>)(lpVtbl[58]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), clientDrawingContext, renderer, originX, originY);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics([NativeTypeName("DWRITE_LINE_METRICS *")] DWRITE_LINE_METRICS* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_LINE_METRICS*, uint, uint*, int>)(lpVtbl[59]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetrics([NativeTypeName("DWRITE_TEXT_METRICS *")] DWRITE_TEXT_METRICS* textMetrics)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_TEXT_METRICS*, int>)(lpVtbl[60]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetOverhangMetrics([NativeTypeName("DWRITE_OVERHANG_METRICS *")] DWRITE_OVERHANG_METRICS* overhangs)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_OVERHANG_METRICS*, int>)(lpVtbl[61]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), overhangs);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClusterMetrics([NativeTypeName("DWRITE_CLUSTER_METRICS *")] DWRITE_CLUSTER_METRICS* clusterMetrics, [NativeTypeName("UINT32")] uint maxClusterCount, [NativeTypeName("UINT32 *")] uint* actualClusterCount)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_CLUSTER_METRICS*, uint, uint*, int>)(lpVtbl[62]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), clusterMetrics, maxClusterCount, actualClusterCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int DetermineMinWidth([NativeTypeName("FLOAT *")] float* minWidth)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float*, int>)(lpVtbl[63]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), minWidth);
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestPoint([NativeTypeName("FLOAT")] float pointX, [NativeTypeName("FLOAT")] float pointY, [NativeTypeName("BOOL *")] int* isTrailingHit, [NativeTypeName("BOOL *")] int* isInside, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float, float, int*, int*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[64]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), pointX, pointY, isTrailingHit, isInside, hitTestMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestTextPosition([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("BOOL")] int isTrailingHit, [NativeTypeName("FLOAT *")] float* pointX, [NativeTypeName("FLOAT *")] float* pointY, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, int, float*, float*, DWRITE_HIT_TEST_METRICS*, int>)(lpVtbl[65]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textPosition, isTrailingHit, pointX, pointY, hitTestMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int HitTestTextRange([NativeTypeName("UINT32")] uint textPosition, [NativeTypeName("UINT32")] uint textLength, [NativeTypeName("FLOAT")] float originX, [NativeTypeName("FLOAT")] float originY, [NativeTypeName("DWRITE_HIT_TEST_METRICS *")] DWRITE_HIT_TEST_METRICS* hitTestMetrics, [NativeTypeName("UINT32")] uint maxHitTestMetricsCount, [NativeTypeName("UINT32 *")] uint* actualHitTestMetricsCount)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, uint, float, float, DWRITE_HIT_TEST_METRICS*, uint, uint*, int>)(lpVtbl[66]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textPosition, textLength, originX, originY, hitTestMetrics, maxHitTestMetricsCount, actualHitTestMetricsCount);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPairKerning([NativeTypeName("BOOL")] int isPairKerningEnabled, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, int, DWRITE_TEXT_RANGE, int>)(lpVtbl[67]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), isPairKerningEnabled, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPairKerning([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("BOOL *")] int* isPairKerningEnabled, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, int*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[68]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, isPairKerningEnabled, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetCharacterSpacing([NativeTypeName("FLOAT")] float leadingSpacing, [NativeTypeName("FLOAT")] float trailingSpacing, [NativeTypeName("FLOAT")] float minimumAdvanceWidth, DWRITE_TEXT_RANGE textRange)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, float, float, float, DWRITE_TEXT_RANGE, int>)(lpVtbl[69]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCharacterSpacing([NativeTypeName("UINT32")] uint currentPosition, [NativeTypeName("FLOAT *")] float* leadingSpacing, [NativeTypeName("FLOAT *")] float* trailingSpacing, [NativeTypeName("FLOAT *")] float* minimumAdvanceWidth, [NativeTypeName("DWRITE_TEXT_RANGE *")] DWRITE_TEXT_RANGE* textRange = null)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, uint, float*, float*, float*, DWRITE_TEXT_RANGE*, int>)(lpVtbl[70]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), currentPosition, leadingSpacing, trailingSpacing, minimumAdvanceWidth, textRange);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMetrics([NativeTypeName("DWRITE_TEXT_METRICS1 *")] DWRITE_TEXT_METRICS1* textMetrics)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_TEXT_METRICS1*, int>)(lpVtbl[71]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), textMetrics);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int>)(lpVtbl[72]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), glyphOrientation);
        }

        public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_VERTICAL_GLYPH_ORIENTATION>)(lpVtbl[73]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLastLineWrapping([NativeTypeName("BOOL")] int isLastLineWrappingEnabled)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, int, int>)(lpVtbl[74]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
        }

        [return: NativeTypeName("BOOL")]
        public int GetLastLineWrapping()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, int>)(lpVtbl[75]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_OPTICAL_ALIGNMENT, int>)(lpVtbl[76]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), opticalAlignment);
        }

        public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_OPTICAL_ALIGNMENT>)(lpVtbl[77]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetFontFallback([NativeTypeName("IDWriteFontFallback *")] IDWriteFontFallback* fontFallback)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, IDWriteFontFallback*, int>)(lpVtbl[78]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFontFallback([NativeTypeName("IDWriteFontFallback **")] IDWriteFontFallback** fontFallback)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, IDWriteFontFallback**, int>)(lpVtbl[79]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), fontFallback);
        }

        [return: NativeTypeName("HRESULT")]
        public int InvalidateLayout()
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, int>)(lpVtbl[80]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_LINE_SPACING*, int>)(lpVtbl[81]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineSpacing([NativeTypeName("DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_LINE_SPACING*, int>)(lpVtbl[82]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetLineMetrics([NativeTypeName("DWRITE_LINE_METRICS1 *")] DWRITE_LINE_METRICS1* lineMetrics, [NativeTypeName("UINT32")] uint maxLineCount, [NativeTypeName("UINT32 *")] uint* actualLineCount)
        {
            return ((delegate* stdcall<IDWriteTextLayout3*, DWRITE_LINE_METRICS1*, uint, uint*, int>)(lpVtbl[83]))((IDWriteTextLayout3*)Unsafe.AsPointer(ref this), lineMetrics, maxLineCount, actualLineCount);
        }
    }
}
