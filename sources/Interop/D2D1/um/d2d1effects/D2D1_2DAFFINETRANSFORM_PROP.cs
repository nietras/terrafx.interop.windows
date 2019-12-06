// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_2DAFFINETRANSFORM_PROP : uint
    {
        D2D1_2DAFFINETRANSFORM_PROP_INTERPOLATION_MODE = 0,
        D2D1_2DAFFINETRANSFORM_PROP_BORDER_MODE = 1,
        D2D1_2DAFFINETRANSFORM_PROP_TRANSFORM_MATRIX = 2,
        D2D1_2DAFFINETRANSFORM_PROP_SHARPNESS = 3,
        D2D1_2DAFFINETRANSFORM_PROP_FORCE_DWORD = 0xffffffff,
    }
}
