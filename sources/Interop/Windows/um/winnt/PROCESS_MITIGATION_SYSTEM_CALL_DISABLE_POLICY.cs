// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY
    {
        [NativeTypeName("_PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11732:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Flags;

            [FieldOffset(0)]
            [NativeTypeName("_PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11734:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                internal uint _bitfield;

                [NativeTypeName("DWORD : 1")]
                public uint DisallowWin32kSystemCalls
                {
                    get
                    {
                        return _bitfield & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                    }
                }

                [NativeTypeName("DWORD : 1")]
                public uint AuditDisallowWin32kSystemCalls
                {
                    get
                    {
                        return (_bitfield >> 1) & 0x1u;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                    }
                }

                [NativeTypeName("DWORD : 30")]
                public uint ReservedFlags
                {
                    get
                    {
                        return (_bitfield >> 2) & 0x3FFFFFFFu;
                    }

                    set
                    {
                        _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                    }
                }
            }
        }
    }
}
