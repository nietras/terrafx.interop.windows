// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F29F6BC0-5021-11CE-AA15-00006901293F")]
    public unsafe partial struct IROTData
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IROTData*, Guid*, void**, int>)(lpVtbl[0]))((IROTData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IROTData*, uint>)(lpVtbl[1]))((IROTData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IROTData*, uint>)(lpVtbl[2]))((IROTData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetComparisonData([NativeTypeName("byte *")] byte* pbData, [NativeTypeName("ULONG")] uint cbMax, [NativeTypeName("ULONG *")] uint* pcbData)
        {
            return ((delegate* stdcall<IROTData*, byte*, uint, uint*, int>)(lpVtbl[3]))((IROTData*)Unsafe.AsPointer(ref this), pbData, cbMax, pcbData);
        }
    }
}
