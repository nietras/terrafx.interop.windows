// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACC-2F86-11D1-8E04-00C04FB9989A")]
    public unsafe partial struct IPipeLong
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IPipeLong*, Guid*, void**, int>)(lpVtbl[0]))((IPipeLong*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IPipeLong*, uint>)(lpVtbl[1]))((IPipeLong*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IPipeLong*, uint>)(lpVtbl[2]))((IPipeLong*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Pull([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cRequest, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return ((delegate* stdcall<IPipeLong*, int*, uint, uint*, int>)(lpVtbl[3]))((IPipeLong*)Unsafe.AsPointer(ref this), buf, cRequest, pcReturned);
        }

        [return: NativeTypeName("HRESULT")]
        public int Push([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return ((delegate* stdcall<IPipeLong*, int*, uint, int>)(lpVtbl[4]))((IPipeLong*)Unsafe.AsPointer(ref this), buf, cSent);
        }
    }
}
