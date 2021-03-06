// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_CAP_STYLE : uint
    {
        D2D1_CAP_STYLE_FLAT = 0,
        D2D1_CAP_STYLE_SQUARE = 1,
        D2D1_CAP_STYLE_ROUND = 2,
        D2D1_CAP_STYLE_TRIANGLE = 3,
        D2D1_CAP_STYLE_FORCE_DWORD = 0xffffffff,
    }
}
