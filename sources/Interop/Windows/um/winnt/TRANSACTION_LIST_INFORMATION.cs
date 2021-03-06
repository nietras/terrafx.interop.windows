// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct TRANSACTION_LIST_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint NumberOfTransactions;

        [NativeTypeName("TRANSACTION_LIST_ENTRY [1]")]
        public _TransactionInformation_e__FixedBuffer TransactionInformation;

        public partial struct _TransactionInformation_e__FixedBuffer
        {
            internal TRANSACTION_LIST_ENTRY e0;

            public ref TRANSACTION_LIST_ENTRY this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<TRANSACTION_LIST_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
