// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002E-0000-0000-C000-000000000046")]
    public unsafe partial struct ITypeFactory
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ITypeFactory*, Guid*, void**, int>)(lpVtbl[0]))((ITypeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ITypeFactory*, uint>)(lpVtbl[1]))((ITypeFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ITypeFactory*, uint>)(lpVtbl[2]))((ITypeFactory*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateFromTypeInfo([NativeTypeName("ITypeInfo *")] ITypeInfo* pTypeInfo, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown **")] IUnknown** ppv)
        {
            return ((delegate* stdcall<ITypeFactory*, ITypeInfo*, Guid*, IUnknown**, int>)(lpVtbl[3]))((ITypeFactory*)Unsafe.AsPointer(ref this), pTypeInfo, riid, ppv);
        }
    }
}
