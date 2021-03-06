// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_3DPERSPECTIVETRANSFORM_PROP : uint
    {
        D2D1_3DPERSPECTIVETRANSFORM_PROP_INTERPOLATION_MODE = 0,
        D2D1_3DPERSPECTIVETRANSFORM_PROP_BORDER_MODE = 1,
        D2D1_3DPERSPECTIVETRANSFORM_PROP_DEPTH = 2,
        D2D1_3DPERSPECTIVETRANSFORM_PROP_PERSPECTIVE_ORIGIN = 3,
        D2D1_3DPERSPECTIVETRANSFORM_PROP_LOCAL_OFFSET = 4,
        D2D1_3DPERSPECTIVETRANSFORM_PROP_GLOBAL_OFFSET = 5,
        D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION_ORIGIN = 6,
        D2D1_3DPERSPECTIVETRANSFORM_PROP_ROTATION = 7,
        D2D1_3DPERSPECTIVETRANSFORM_PROP_FORCE_DWORD = 0xffffffff,
    }
}
