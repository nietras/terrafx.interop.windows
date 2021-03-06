// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const uint DXGI_ENUM_MODES_STEREO = 4;

        public const uint DXGI_ENUM_MODES_DISABLED_STEREO = 8;

        public const uint DXGI_SHARED_RESOURCE_READ = 0x80000000;

        public const uint DXGI_SHARED_RESOURCE_WRITE = 1;

        public static readonly Guid IID_IDXGIDisplayControl = new Guid(0xEA9DBF1A, 0xC88E, 0x4486, 0x85, 0x4A, 0x98, 0xAA, 0x01, 0x38, 0xF3, 0x0C);

        public static readonly Guid IID_IDXGIOutputDuplication = new Guid(0x191CFAC3, 0xA341, 0x470D, 0xB2, 0x6E, 0xA8, 0x64, 0xF4, 0x28, 0x31, 0x9C);

        public static readonly Guid IID_IDXGISurface2 = new Guid(0xABA496DD, 0xB617, 0x4CB8, 0xA8, 0x66, 0xBC, 0x44, 0xD7, 0xEB, 0x1F, 0xA2);

        public static readonly Guid IID_IDXGIResource1 = new Guid(0x30961379, 0x4609, 0x4A41, 0x99, 0x8E, 0x54, 0xFE, 0x56, 0x7E, 0xE0, 0xC1);

        public static readonly Guid IID_IDXGIDevice2 = new Guid(0x05008617, 0xFBFD, 0x4051, 0xA7, 0x90, 0x14, 0x48, 0x84, 0xB4, 0xF6, 0xA9);

        public static readonly Guid IID_IDXGISwapChain1 = new Guid(0x790A45F7, 0x0D42, 0x4876, 0x98, 0x3A, 0x0A, 0x55, 0xCF, 0xE6, 0xF4, 0xAA);

        public static readonly Guid IID_IDXGIFactory2 = new Guid(0x50C83A1C, 0xE072, 0x4C48, 0x87, 0xB0, 0x36, 0x30, 0xFA, 0x36, 0xA6, 0xD0);

        public static readonly Guid IID_IDXGIAdapter2 = new Guid(0x0AA1AE0A, 0xFA0E, 0x4B84, 0x86, 0x44, 0xE0, 0x5F, 0xF8, 0xE5, 0xAC, 0xB5);

        public static readonly Guid IID_IDXGIOutput1 = new Guid(0x00CDDEA8, 0x939B, 0x4B83, 0xA3, 0x40, 0xA6, 0x85, 0x22, 0x66, 0x66, 0xCC);
    }
}
