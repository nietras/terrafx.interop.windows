// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPSHEETPAGEW_V1
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("HINSTANCE")]
        public IntPtr hInstance;

        [NativeTypeName("_PROPSHEETPAGEW_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:244:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_PROPSHEETPAGEW_V1::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/prsht.h:244:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("LPCWSTR")]
        public ushort* pszTitle;

        [NativeTypeName("DLGPROC")]
        public delegate* stdcall<IntPtr, uint, nuint, nint, nint> pfnDlgProc;

        [NativeTypeName("LPARAM")]
        public nint lParam;

        [NativeTypeName("LPFNPSPCALLBACKW")]
        public delegate* stdcall<IntPtr, uint, PROPSHEETPAGEW*, uint> pfnCallback;

        [NativeTypeName("UINT *")]
        public uint* pcRefParent;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszTemplate;

            [FieldOffset(0)]
            [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
            public DLGTEMPLATE* pResource;
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HICON")]
            public IntPtr hIcon;

            [FieldOffset(0)]
            [NativeTypeName("LPCWSTR")]
            public ushort* pszIcon;
        }
    }
}
