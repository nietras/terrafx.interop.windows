// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C62D9C91-7458-47F6-862D-1EF86FB0B278")]
    public unsafe partial struct ISpeechAudioStatus
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, uint>)(lpVtbl[1]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, uint>)(lpVtbl[2]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, uint*, int>)(lpVtbl[3]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_FreeBufferSpace([NativeTypeName("long *")] int* FreeBufferSpace)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, int*, int>)(lpVtbl[7]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), FreeBufferSpace);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_NonBlockingIO([NativeTypeName("long *")] int* NonBlockingIO)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, int*, int>)(lpVtbl[8]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), NonBlockingIO);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_State([NativeTypeName("SpeechAudioState *")] SpeechAudioState* State)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, SpeechAudioState*, int>)(lpVtbl[9]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), State);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CurrentSeekPosition([NativeTypeName("VARIANT *")] VARIANT* CurrentSeekPosition)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, VARIANT*, int>)(lpVtbl[10]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), CurrentSeekPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_CurrentDevicePosition([NativeTypeName("VARIANT *")] VARIANT* CurrentDevicePosition)
        {
            return ((delegate* stdcall<ISpeechAudioStatus*, VARIANT*, int>)(lpVtbl[11]))((ISpeechAudioStatus*)Unsafe.AsPointer(ref this), CurrentDevicePosition);
        }
    }
}
