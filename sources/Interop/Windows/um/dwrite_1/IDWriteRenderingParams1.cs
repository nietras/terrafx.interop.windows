// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The interface that represents text rendering settings for glyph rasterization and filtering.</summary>
    [Guid("94413CF4-A6FC-4248-8B50-6674348FCAD3")]
    public unsafe struct IDWriteRenderingParams1
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDWriteRenderingParams1* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDWriteRenderingParams1* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDWriteRenderingParams1* This
        );

        /// <summary>Gets the gamma value used for gamma correction. Valid values must be greater than zero and cannot exceed 256.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetGamma(
            [In] IDWriteRenderingParams1* This
        );

        /// <summary>Gets the amount of contrast enhancement. Valid values are greater than or equal to zero.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetEnhancedContrast(
            [In] IDWriteRenderingParams1* This
        );

        /// <summary>Gets the ClearType level. Valid values range from 0.0f (no ClearType) to 1.0f (full ClearType).</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate float _GetClearTypeLevel(
            [In] IDWriteRenderingParams1* This
        );

        /// <summary>Gets the pixel geometry.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_PIXEL_GEOMETRY _GetPixelGeometry(
            [In] IDWriteRenderingParams1* This
        );

        /// <summary>Gets the rendering mode.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DWRITE_RENDERING_MODE _GetRenderingMode(
            [In] IDWriteRenderingParams1* This
        );

        /// <summary>Gets the amount of contrast enhancement to use for grayscale antialiasing. Valid values are greater than or equal to zero.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetGrayscaleEnhancedContrast(
            [In] IDWriteRenderingParams1* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDWriteRenderingParams1* This = &this)
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
            fixed (IDWriteRenderingParams1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteRenderingParams1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            fixed (IDWriteRenderingParams1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGamma>(lpVtbl->GetGamma)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            fixed (IDWriteRenderingParams1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetEnhancedContrast>(lpVtbl->GetEnhancedContrast)(
                    This
                );
            }
        }

        public float GetClearTypeLevel()
        {
            fixed (IDWriteRenderingParams1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetClearTypeLevel>(lpVtbl->GetClearTypeLevel)(
                    This
                );
            }
        }

        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            fixed (IDWriteRenderingParams1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPixelGeometry>(lpVtbl->GetPixelGeometry)(
                    This
                );
            }
        }

        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            fixed (IDWriteRenderingParams1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetRenderingMode>(lpVtbl->GetRenderingMode)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGrayscaleEnhancedContrast()
        {
            fixed (IDWriteRenderingParams1* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetGrayscaleEnhancedContrast>(lpVtbl->GetGrayscaleEnhancedContrast)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetGamma;

            public IntPtr GetEnhancedContrast;

            public IntPtr GetClearTypeLevel;

            public IntPtr GetPixelGeometry;

            public IntPtr GetRenderingMode;

            public IntPtr GetGrayscaleEnhancedContrast;
        }
    }
}
