// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CERT_LOGOTYPE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint dwLogotypeInfoChoice;

        [NativeTypeName("_CERT_LOGOTYPE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/wincrypt.h:5512:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PCERT_LOGOTYPE_DATA")]
            public CERT_LOGOTYPE_DATA* pLogotypeDirectInfo;

            [FieldOffset(0)]
            [NativeTypeName("PCERT_LOGOTYPE_REFERENCE")]
            public CERT_LOGOTYPE_REFERENCE* pLogotypeIndirectInfo;
        }
    }
}
