// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETHEADERA_V2
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HWND")]
        public IntPtr hwndParent;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("_PROPSHEETHEADERA_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:479:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("LPCSTR")]
        public sbyte* pszCaption;

        [NativeTypeName("UINT")]
        public uint nPages;

        [NativeTypeName("_PROPSHEETHEADERA_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:479:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("_PROPSHEETHEADERA_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:479:5)")]
        public _Anonymous3_e__Union Anonymous3;

        [NativeTypeName("PFNPROPSHEETCALLBACK")]
        public delegate* stdcall<IntPtr, uint, nint, int> pfnCallback;

        [NativeTypeName("_PROPSHEETHEADERA_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:480:5)")]
        public _Anonymous4_e__Union Anonymous4;

        [NativeTypeName("HPALETTE")]
        public IntPtr hplWatermark;

        [NativeTypeName("_PROPSHEETHEADERA_V2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:486:5)")]
        public _Anonymous5_e__Union Anonymous5;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HICON")]
            public IntPtr hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszIcon;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint nStartPage;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pStartPage;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous3_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPCPROPSHEETPAGEA")]
            public PROPSHEETPAGEA* ppsp;

            [FieldOffset(0)]
            [NativeTypeName("HPROPSHEETPAGE *")]
            public IntPtr* phpage;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous4_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hbmWatermark;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszbmWatermark;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous5_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HBITMAP")]
            public IntPtr hbmHeader;

            [FieldOffset(0)]
            [NativeTypeName("LPCSTR")]
            public sbyte* pszbmHeader;
        }
    }
}
