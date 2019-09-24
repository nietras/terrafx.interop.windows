// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000040-A8F2-4877-BA0A-FD2B6645FB94")]
    public unsafe struct IWICPalette
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IWICPalette* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IWICPalette* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IWICPalette* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializePredefined(
            [In] IWICPalette* This,
            [In] WICBitmapPaletteType ePaletteType,
            [In, NativeTypeName("BOOL")] int fAddTransparentColor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeCustom(
            [In] IWICPalette* This,
            [In, NativeTypeName("WICColor[]")] uint* pColors,
            [In, NativeTypeName("UINT")] uint cCount
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromBitmap(
            [In] IWICPalette* This,
            [In, Optional] IWICBitmapSource* pISurface,
            [In, NativeTypeName("UINT")] uint cCount,
            [In, NativeTypeName("BOOL")] int fAddTransparentColor
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitializeFromPalette(
            [In] IWICPalette* This,
            [In] IWICPalette* pIPalette = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int __GetType(
            [In] IWICPalette* This,
            [Out] WICBitmapPaletteType* pePaletteType
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColorCount(
            [In] IWICPalette* This,
            [Out, NativeTypeName("UINT")] uint* pcCount
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetColors(
            [In] IWICPalette* This,
            [In, NativeTypeName("UINT")] uint cCount,
            [Out, NativeTypeName("WICColor[]")] uint* pColors,
            [Out, NativeTypeName("UINT")] uint* pcActualColors
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsBlackWhite(
            [In] IWICPalette* This,
            [Out, NativeTypeName("BOOL")] int* pfIsBlackWhite
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsGrayscale(
            [In] IWICPalette* This,
            [Out, NativeTypeName("BOOL")] int* pfIsGrayscale
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _HasAlpha(
            [In] IWICPalette* This,
            [Out, NativeTypeName("BOOL")] int* pfHasAlpha
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializePredefined(
            [In] WICBitmapPaletteType ePaletteType,
            [In, NativeTypeName("BOOL")] int fAddTransparentColor
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializePredefined>(lpVtbl->InitializePredefined)(
                    This,
                    ePaletteType,
                    fAddTransparentColor
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeCustom(
            [In, NativeTypeName("WICColor[]")] uint* pColors,
            [In, NativeTypeName("UINT")] uint cCount
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeCustom>(lpVtbl->InitializeCustom)(
                    This,
                    pColors,
                    cCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromBitmap(
            [In, Optional] IWICBitmapSource* pISurface,
            [In, NativeTypeName("UINT")] uint cCount,
            [In, NativeTypeName("BOOL")] int fAddTransparentColor
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromBitmap>(lpVtbl->InitializeFromBitmap)(
                    This,
                    pISurface,
                    cCount,
                    fAddTransparentColor
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int InitializeFromPalette(
            [In] IWICPalette* pIPalette = null
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_InitializeFromPalette>(lpVtbl->InitializeFromPalette)(
                    This,
                    pIPalette
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int _GetType(
            [Out] WICBitmapPaletteType* pePaletteType
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<__GetType>(lpVtbl->_GetType)(
                    This,
                    pePaletteType
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColorCount(
            [Out, NativeTypeName("UINT")] uint* pcCount
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColorCount>(lpVtbl->GetColorCount)(
                    This,
                    pcCount
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetColors(
            [In, NativeTypeName("UINT")] uint cCount,
            [Out, NativeTypeName("WICColor[]")] uint* pColors,
            [Out, NativeTypeName("UINT")] uint* pcActualColors
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetColors>(lpVtbl->GetColors)(
                    This,
                    cCount,
                    pColors,
                    pcActualColors
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsBlackWhite(
            [Out, NativeTypeName("BOOL")] int* pfIsBlackWhite
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsBlackWhite>(lpVtbl->IsBlackWhite)(
                    This,
                    pfIsBlackWhite
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int IsGrayscale(
            [Out, NativeTypeName("BOOL")] int* pfIsGrayscale
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_IsGrayscale>(lpVtbl->IsGrayscale)(
                    This,
                    pfIsGrayscale
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int HasAlpha(
            [Out, NativeTypeName("BOOL")] int* pfHasAlpha
        )
        {
            fixed (IWICPalette* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_HasAlpha>(lpVtbl->HasAlpha)(
                    This,
                    pfHasAlpha
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr InitializePredefined;

            public IntPtr InitializeCustom;

            public IntPtr InitializeFromBitmap;

            public IntPtr InitializeFromPalette;

            public IntPtr _GetType;

            public IntPtr GetColorCount;

            public IntPtr GetColors;

            public IntPtr IsBlackWhite;

            public IntPtr IsGrayscale;

            public IntPtr HasAlpha;
        }
    }
}
