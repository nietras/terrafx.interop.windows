// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The font file enumerator interface encapsulates a collection of font files. The font system uses this interface to enumerate font files when building a font collection.</summary>
    [Guid("72755049-5FF7-435D-8348-4BE97CFA6C7C")]
    public unsafe struct IDWriteFontFileEnumerator
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontFileEnumerator* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontFileEnumerator* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontFileEnumerator* This);

        /// <summary>Advances to the next font file in the collection. When it is first created, the enumerator is positioned before the first element of the collection and the first call to MoveNext advances to the first file.</summary>
        /// <param name="hasCurrentFile">Receives the value TRUE if the enumerator advances to a file, or FALSE if the enumerator advanced past the last file in the collection.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MoveNext(IDWriteFontFileEnumerator* This, [NativeTypeName("BOOL")] int* hasCurrentFile);

        /// <summary>Gets a reference to the current font file.</summary>
        /// <param name="fontFile">Pointer to the newly created font file object.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetCurrentFontFile(IDWriteFontFileEnumerator* This, IDWriteFontFile** fontFile);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MoveNext([NativeTypeName("BOOL")] int* hasCurrentFile)
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MoveNext>(lpVtbl->MoveNext)(This, hasCurrentFile);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetCurrentFontFile(IDWriteFontFile** fontFile)
        {
            fixed (IDWriteFontFileEnumerator* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetCurrentFontFile>(lpVtbl->GetCurrentFontFile)(This, fontFile);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr MoveNext;

            public IntPtr GetCurrentFontFile;
        }
    }
}
