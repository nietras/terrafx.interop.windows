// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_6.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [Unmanaged]
    public unsafe struct DXGI_OUTPUT_DESC1
    {
        #region Fields
        [NativeTypeName("WCHAR[32]")]
        public fixed char DeviceName[32];

        public RECT DesktopCoordinates;

        [NativeTypeName("BOOL")]
        public int AttachedToDesktop;

        public DXGI_MODE_ROTATION Rotation;

        [NativeTypeName("HMONITOR")]
        public IntPtr Monitor;

        [NativeTypeName("UINT")]
        public uint BitsPerColor;

        public DXGI_COLOR_SPACE_TYPE ColorSpace;

        [NativeTypeName("FLOAT[2]")]
        public fixed float RedPrimary[2];

        [NativeTypeName("FLOAT[2]")]
        public fixed float GreenPrimary[2];

        [NativeTypeName("FLOAT[2]")]
        public fixed float BluePrimary[2];

        [NativeTypeName("FLOAT[2]")]
        public fixed float WhitePoint[2];

        [NativeTypeName("FLOAT")]
        public float MinLuminance;

        [NativeTypeName("FLOAT")]
        public float MaxLuminance;

        [NativeTypeName("FLOAT")]
        public float MaxFullFrameLuminance;
        #endregion
    }
}