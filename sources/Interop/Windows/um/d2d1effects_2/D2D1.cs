// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class D2D1
    {
        public static readonly Guid CLSID_D2D1Contrast = new Guid(0xB648A78A, 0x0ED5, 0x4F80, 0xA9, 0x4A, 0x8E, 0x82, 0x5A, 0xCA, 0x6B, 0x77);

        public static readonly Guid CLSID_D2D1RgbToHue = new Guid(0x23F3E5EC, 0x91E8, 0x4D3D, 0xAD, 0x0A, 0xAF, 0xAD, 0xC1, 0x00, 0x4A, 0xA1);

        public static readonly Guid CLSID_D2D1HueToRgb = new Guid(0x7B78A6BD, 0x0141, 0x4DEF, 0x8A, 0x52, 0x63, 0x56, 0xEE, 0x0C, 0xBD, 0xD5);

        public static readonly Guid CLSID_D2D1ChromaKey = new Guid(0x74C01F5B, 0x2A0D, 0x408C, 0x88, 0xE2, 0xC7, 0xA3, 0xC7, 0x19, 0x77, 0x42);

        public static readonly Guid CLSID_D2D1Emboss = new Guid(0xB1C5EB2B, 0x0348, 0x43F0, 0x81, 0x07, 0x49, 0x57, 0xCA, 0xCB, 0xA2, 0xAE);

        public static readonly Guid CLSID_D2D1Exposure = new Guid(0xB56C8CFA, 0xF634, 0x41EE, 0xBE, 0xE0, 0xFF, 0xA6, 0x17, 0x10, 0x60, 0x04);

        public static readonly Guid CLSID_D2D1Grayscale = new Guid(0x36DDE0EB, 0x3725, 0x42E0, 0x83, 0x6D, 0x52, 0xFB, 0x20, 0xAE, 0xE6, 0x44);

        public static readonly Guid CLSID_D2D1Invert = new Guid(0xE0C3784D, 0xCB39, 0x4E84, 0xB6, 0xFD, 0x6B, 0x72, 0xF0, 0x81, 0x02, 0x63);

        public static readonly Guid CLSID_D2D1Posterize = new Guid(0x2188945E, 0x33A3, 0x4366, 0xB7, 0xBC, 0x08, 0x6B, 0xD0, 0x2D, 0x08, 0x84);

        public static readonly Guid CLSID_D2D1Sepia = new Guid(0x3A1AF410, 0x5F1D, 0x4DBE, 0x84, 0xDF, 0x91, 0x5D, 0xA7, 0x9B, 0x71, 0x53);

        public static readonly Guid CLSID_D2D1Sharpen = new Guid(0xC9B887CB, 0xC5FF, 0x4DC5, 0x97, 0x79, 0x27, 0x3D, 0xCF, 0x41, 0x7C, 0x7D);

        public static readonly Guid CLSID_D2D1Straighten = new Guid(0x4DA47B12, 0x79A3, 0x4FB0, 0x82, 0x37, 0xBB, 0xC3, 0xB2, 0xA4, 0xDE, 0x08);

        public static readonly Guid CLSID_D2D1TemperatureTint = new Guid(0x89176087, 0x8AF9, 0x4A08, 0xAE, 0xB1, 0x89, 0x5F, 0x38, 0xDB, 0x17, 0x66);

        public static readonly Guid CLSID_D2D1Vignette = new Guid(0xC00C40BE, 0x5E67, 0x4CA3, 0x95, 0xB4, 0xF4, 0xB0, 0x2C, 0x11, 0x51, 0x35);

        public static readonly Guid CLSID_D2D1EdgeDetection = new Guid(0xEFF583CA, 0xCB07, 0x4AA9, 0xAC, 0x5D, 0x2C, 0xC4, 0x4C, 0x76, 0x46, 0x0F);

        public static readonly Guid CLSID_D2D1HighlightsShadows = new Guid(0xCADC8384, 0x323F, 0x4C7E, 0xA3, 0x61, 0x2E, 0x2B, 0x24, 0xDF, 0x6E, 0xE4);

        public static readonly Guid CLSID_D2D1LookupTable3D = new Guid(0x349E0EDA, 0x0088, 0x4A79, 0x9C, 0xA3, 0xC7, 0xE3, 0x00, 0x20, 0x20, 0x20);

        public static readonly Guid CLSID_D2D1Opacity = new Guid(0x811D79A4, 0xDE28, 0x4454, 0x80, 0x94, 0xC6, 0x46, 0x85, 0xF8, 0xBD, 0x4C);

        public static readonly Guid CLSID_D2D1AlphaMask = new Guid(0xC80ECFF0, 0x3FD5, 0x4F05, 0x83, 0x28, 0xC5, 0xD1, 0x72, 0x4B, 0x4F, 0x0A);

        public static readonly Guid CLSID_D2D1CrossFade = new Guid(0x12F575E8, 0x4DB1, 0x485F, 0x9A, 0x84, 0x03, 0xA0, 0x7D, 0xD3, 0x82, 0x9F);

        public static readonly Guid CLSID_D2D1Tint = new Guid(0x36312B17, 0xF7DD, 0x4014, 0x91, 0x5D, 0xFF, 0xCA, 0x76, 0x8C, 0xF2, 0x11);
    }
}
