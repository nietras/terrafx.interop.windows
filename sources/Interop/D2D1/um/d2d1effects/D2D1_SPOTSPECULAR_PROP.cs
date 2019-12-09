// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_SPOTSPECULAR_PROP : uint
    {
        D2D1_SPOTSPECULAR_PROP_LIGHT_POSITION = 0,
        D2D1_SPOTSPECULAR_PROP_POINTS_AT = 1,
        D2D1_SPOTSPECULAR_PROP_FOCUS = 2,
        D2D1_SPOTSPECULAR_PROP_LIMITING_CONE_ANGLE = 3,
        D2D1_SPOTSPECULAR_PROP_SPECULAR_EXPONENT = 4,
        D2D1_SPOTSPECULAR_PROP_SPECULAR_CONSTANT = 5,
        D2D1_SPOTSPECULAR_PROP_SURFACE_SCALE = 6,
        D2D1_SPOTSPECULAR_PROP_COLOR = 7,
        D2D1_SPOTSPECULAR_PROP_KERNEL_UNIT_LENGTH = 8,
        D2D1_SPOTSPECULAR_PROP_SCALE_MODE = 9,
        D2D1_SPOTSPECULAR_PROP_FORCE_DWORD = 0xffffffff,
    }
}