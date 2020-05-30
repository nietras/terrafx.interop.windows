// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct MIXERCONTROLW
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("DWORD")]
        public uint dwControlID;

        [NativeTypeName("DWORD")]
        public uint dwControlType;

        [NativeTypeName("DWORD")]
        public uint fdwControl;

        [NativeTypeName("DWORD")]
        public uint cMultipleItems;

        [NativeTypeName("WCHAR [16]")]
        public fixed ushort szShortName[16];

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort szName[64];

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2113:5)")]
        public _Bounds_e__Union Bounds;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2124:5)")]
        public _Metrics_e__Union Metrics;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Bounds_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("tagMIXERCONTROLW::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2114:9)")]
            public _Anonymous1_e__Struct Anonymous1;

            [FieldOffset(0)]
            [NativeTypeName("tagMIXERCONTROLW::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/mmeapi.h:2118:9)")]
            public _Anonymous2_e__Struct Anonymous2;

            [FieldOffset(0)]
            [NativeTypeName("DWORD [6]")]
            public fixed uint dwReserved[6];

            public partial struct _Anonymous1_e__Struct
            {
                [NativeTypeName("LONG")]
                public int lMinimum;

                [NativeTypeName("LONG")]
                public int lMaximum;
            }

            public partial struct _Anonymous2_e__Struct
            {
                [NativeTypeName("DWORD")]
                public uint dwMinimum;

                [NativeTypeName("DWORD")]
                public uint dwMaximum;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Metrics_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cSteps;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint cbCustomData;

            [FieldOffset(0)]
            [NativeTypeName("DWORD [6]")]
            public fixed uint dwReserved[6];
        }
    }
}
