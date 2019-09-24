// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020403-0000-0000-C000-000000000046")]
    public unsafe struct ITypeComp
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] ITypeComp* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] ITypeComp* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] ITypeComp* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Bind(
            [In] ITypeComp* This,
            [In, NativeTypeName("LPOLESTR")] char* szName,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [In, NativeTypeName("WORD")] ushort wFlags,
            [Out] ITypeInfo** ppTInfo,
            [Out] DESCKIND* pDescKind,
            [Out] BINDPTR* pBindPtr
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _BindType(
            [In] ITypeComp* This,
            [In, NativeTypeName("LPOLESTR")] char* szName,
            [In, NativeTypeName("ULONG")] uint lHashVal,
            [Out] ITypeInfo** ppTInfo,
            [Out] ITypeComp** ppTComp
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ITypeComp* This = &this)
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
            fixed (ITypeComp* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ITypeComp* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        // [return: NativeTypeName("HRESULT")]
        // public int Bind(
        //     [In, NativeTypeName("LPOLESTR")] char* szName,
        //     [In, NativeTypeName("ULONG")] uint lHashVal,
        //     [In, NativeTypeName("WORD")] ushort wFlags,
        //     [Out] ITypeInfo** ppTInfo,
        //     [Out] DESCKIND* pDescKind,
        //     [Out] BINDPTR* pBindPtr
        // )
        // {
        //     fixed (ITypeComp* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_Bind>(lpVtbl->Bind)(
        //             This,
        //             szName,
        //             lHashVal,
        //             wFlags,
        //             ppTInfo,
        //             pDescKind,
        //             pBindPtr
        //         );
        //     }
        // }

        // [return: NativeTypeName("HRESULT")]
        // public int BindType(
        //     [In, NativeTypeName("LPOLESTR")] char* szName,
        //     [In, NativeTypeName("ULONG")] uint lHashVal,
        //     [Out] ITypeInfo** ppTInfo,
        //     [Out] ITypeComp** ppTComp
        // )
        // {
        //     fixed (ITypeComp* This = &this)
        //     {
        //         return Marshal.GetDelegateForFunctionPointer<_BindType>(lpVtbl->BindType)(
        //             This,
        //             szName,
        //             lHashVal,
        //             ppTInfo,
        //             ppTComp
        //         );
        //     }
        // }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr Bind;

            public IntPtr BindType;
        }
    }
}
