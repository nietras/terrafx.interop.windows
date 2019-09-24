// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>Provides access to an device context that can accept GDI drawing commands.</summary>
    [Guid("E0DB51C3-6F77-4BAE-B3D5-E47509B35838")]
    public unsafe struct ID2D1GdiInteropRenderTarget
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ID2D1GdiInteropRenderTarget* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ID2D1GdiInteropRenderTarget* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ID2D1GdiInteropRenderTarget* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetDC(
            [In] ID2D1GdiInteropRenderTarget* This,
            [In] D2D1_DC_INITIALIZE_MODE mode,
            [Out, NativeTypeName("HDC")] IntPtr* hdc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseDC(
            [In] ID2D1GdiInteropRenderTarget* This,
            [In] RECT* update = null
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1GdiInteropRenderTarget* This = &this)
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
            fixed (ID2D1GdiInteropRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1GdiInteropRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDC(
            [In] D2D1_DC_INITIALIZE_MODE mode,
            [Out, NativeTypeName("HDC")] IntPtr* hdc
        )
        {
            fixed (ID2D1GdiInteropRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetDC>(lpVtbl->GetDC)(
                    This,
                    mode,
                    hdc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseDC(
            [In] RECT* update = null
        )
        {
            fixed (ID2D1GdiInteropRenderTarget* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReleaseDC>(lpVtbl->ReleaseDC)(
                    This,
                    update
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetDC;

            public IntPtr ReleaseDC;
        }
    }
}
