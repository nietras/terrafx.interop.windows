// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CCA920E4-52F0-492B-BFA8-29C72EE0A468")]
    public unsafe partial struct IDWriteFontCollectionLoader
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IDWriteFontCollectionLoader*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IDWriteFontCollectionLoader*, uint>)(lpVtbl[1]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IDWriteFontCollectionLoader*, uint>)(lpVtbl[2]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEnumeratorFromKey([NativeTypeName("IDWriteFactory *")] IDWriteFactory* factory, [NativeTypeName("const void *")] void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, [NativeTypeName("IDWriteFontFileEnumerator **")] IDWriteFontFileEnumerator** fontFileEnumerator)
        {
            return ((delegate* stdcall<IDWriteFontCollectionLoader*, IDWriteFactory*, void*, uint, IDWriteFontFileEnumerator**, int>)(lpVtbl[3]))((IDWriteFontCollectionLoader*)Unsafe.AsPointer(ref this), factory, collectionKey, collectionKeySize, fontFileEnumerator);
        }
    }
}
