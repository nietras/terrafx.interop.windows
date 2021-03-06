// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000140-0000-0000-C000-000000000046")]
    public unsafe partial struct IClassActivator
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IClassActivator*, Guid*, void**, int>)(lpVtbl[0]))((IClassActivator*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IClassActivator*, uint>)(lpVtbl[1]))((IClassActivator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IClassActivator*, uint>)(lpVtbl[2]))((IClassActivator*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClassContext, [NativeTypeName("LCID")] uint locale, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv)
        {
            return ((delegate* stdcall<IClassActivator*, Guid*, uint, uint, Guid*, void**, int>)(lpVtbl[3]))((IClassActivator*)Unsafe.AsPointer(ref this), rclsid, dwClassContext, locale, riid, ppv);
        }
    }
}
