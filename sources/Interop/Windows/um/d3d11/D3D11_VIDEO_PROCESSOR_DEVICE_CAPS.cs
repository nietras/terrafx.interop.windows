// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D11_VIDEO_PROCESSOR_DEVICE_CAPS
    {
        D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_LINEAR_SPACE = 0x1,
        D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_xvYCC = 0x2,
        D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_RGB_RANGE_CONVERSION = 0x4,
        D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_YCbCr_MATRIX_CONVERSION = 0x8,
        D3D11_VIDEO_PROCESSOR_DEVICE_CAPS_NOMINAL_RANGE = 0x10,
    }
}
