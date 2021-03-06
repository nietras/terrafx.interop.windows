// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("BB8A4953-2C99-4F5A-96F5-4819027FA3AC")]
    public unsafe partial struct IDCompositionSurface
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDCompositionSurface*, Guid*, void**, int>)(lpVtbl[0]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDCompositionSurface*, uint>)(lpVtbl[1]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDCompositionSurface*, uint>)(lpVtbl[2]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** updateObject, [NativeTypeName("POINT *")] POINT* updateOffset)
        {
            return ((delegate* stdcall<IDCompositionSurface*, RECT*, Guid*, void**, POINT*, int>)(lpVtbl[3]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
        }

        [return: NativeTypeName("HRESULT")]
        public int EndDraw()
        {
            return ((delegate* stdcall<IDCompositionSurface*, int>)(lpVtbl[4]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SuspendDraw()
        {
            return ((delegate* stdcall<IDCompositionSurface*, int>)(lpVtbl[5]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int ResumeDraw()
        {
            return ((delegate* stdcall<IDCompositionSurface*, int>)(lpVtbl[6]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
        {
            return ((delegate* stdcall<IDCompositionSurface*, RECT*, RECT*, int, int, int>)(lpVtbl[7]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
        }
    }
}
