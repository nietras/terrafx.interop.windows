// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum WICComponentSigning : uint
    {
        WICComponentSigned = 0x1,
        WICComponentUnsigned = 0x2,
        WICComponentSafe = 0x4,
        WICComponentDisabled = 0x80000000,
        WICCOMPONENTSIGNING_FORCE_DWORD = 0x7fffffff,
    }
}
