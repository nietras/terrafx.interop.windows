// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("EEB14B68-808B-4ABE-A5EA-B51DA7588008")]
    public unsafe partial struct ISpeechMemoryStream
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, uint>)(lpVtbl[1]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, uint>)(lpVtbl[2]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, uint*, int>)(lpVtbl[3]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_Format([NativeTypeName("ISpeechAudioFormat **")] ISpeechAudioFormat** AudioFormat)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, ISpeechAudioFormat**, int>)(lpVtbl[7]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int putref_Format([NativeTypeName("ISpeechAudioFormat *")] ISpeechAudioFormat* AudioFormat)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, ISpeechAudioFormat*, int>)(lpVtbl[8]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), AudioFormat);
        }

        [return: NativeTypeName("HRESULT")]
        public int Read([NativeTypeName("VARIANT *")] VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, VARIANT*, int, int*, int>)(lpVtbl[9]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), Buffer, NumberOfBytes, BytesRead);
        }

        [return: NativeTypeName("HRESULT")]
        public int Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, VARIANT, int*, int>)(lpVtbl[10]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), Buffer, BytesWritten);
        }

        [return: NativeTypeName("HRESULT")]
        public int Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, [NativeTypeName("VARIANT *")] VARIANT* NewPosition)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int>)(lpVtbl[11]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), Position, Origin, NewPosition);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetData(VARIANT Data)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, VARIANT, int>)(lpVtbl[12]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), Data);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetData([NativeTypeName("VARIANT *")] VARIANT* pData)
        {
            return ((delegate* stdcall<ISpeechMemoryStream*, VARIANT*, int>)(lpVtbl[13]))((ISpeechMemoryStream*)Unsafe.AsPointer(ref this), pData);
        }
    }
}
