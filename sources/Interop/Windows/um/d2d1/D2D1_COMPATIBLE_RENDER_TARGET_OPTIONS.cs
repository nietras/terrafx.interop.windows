// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    [NativeTypeName("int")]
    public enum D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS : uint
    {
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_NONE = 0x00000000,
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_GDI_COMPATIBLE = 0x00000001,
        D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS_FORCE_DWORD = 0xffffffff,
    }
}
