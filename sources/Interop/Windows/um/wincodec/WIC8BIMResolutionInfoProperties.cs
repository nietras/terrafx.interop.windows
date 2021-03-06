// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WIC8BIMResolutionInfoProperties
    {
        WIC8BIMResolutionInfoPString = 0x1,
        WIC8BIMResolutionInfoHResolution = 0x2,
        WIC8BIMResolutionInfoHResolutionUnit = 0x3,
        WIC8BIMResolutionInfoWidthUnit = 0x4,
        WIC8BIMResolutionInfoVResolution = 0x5,
        WIC8BIMResolutionInfoVResolutionUnit = 0x6,
        WIC8BIMResolutionInfoHeightUnit = 0x7,
        WIC8BIMResolutionInfoProperties_FORCE_DWORD = 0x7fffffff,
    }
}
