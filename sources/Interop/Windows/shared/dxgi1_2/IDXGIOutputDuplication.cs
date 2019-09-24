// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("191CFAC3-A341-470D-B26E-A864F428319C")]
    public unsafe struct IDXGIOutputDuplication
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(
            [In] IDXGIOutputDuplication* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(
            [In] IDXGIOutputDuplication* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateData(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetPrivateDataInterface(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetPrivateData(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetParent(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetDesc(
            [In] IDXGIOutputDuplication* This,
            [Out] DXGI_OUTDUPL_DESC* pDesc
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _AcquireNextFrame(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("UINT")] uint TimeoutInMilliseconds,
            [Out] DXGI_OUTDUPL_FRAME_INFO* pFrameInfo,
            [Out] IDXGIResource** ppDesktopResource
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameDirtyRects(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("UINT")] uint DirtyRectsBufferSize,
            [Out, NativeTypeName("RECT[]")] RECT* pDirtyRectsBuffer,
            [Out, NativeTypeName("UINT")] uint* pDirtyRectsBufferSizeRequired
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFrameMoveRects(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("UINT")] uint MoveRectsBufferSize,
            [Out, NativeTypeName("DXGI_OUTDUPL_MOVE_RECT[]")] DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer,
            [Out, NativeTypeName("UINT")] uint* pMoveRectsBufferSizeRequired
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFramePointerShape(
            [In] IDXGIOutputDuplication* This,
            [In, NativeTypeName("UINT")] uint PointerShapeBufferSize,
            [Out] void* pPointerShapeBuffer,
            [Out, NativeTypeName("UINT")] uint* pPointerShapeBufferSizeRequired,
            [Out] DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _MapDesktopSurface(
            [In] IDXGIOutputDuplication* This,
            [Out] DXGI_MAPPED_RECT* pLockedRect
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _UnMapDesktopSurface(
            [In] IDXGIOutputDuplication* This
        );

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _ReleaseFrame(
            [In] IDXGIOutputDuplication* This
        );

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
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
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, NativeTypeName("UINT")] uint DataSize,
            [In] void* pData
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateData>(lpVtbl->SetPrivateData)(
                    This,
                    Name,
                    DataSize,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int SetPrivateDataInterface(
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In] IUnknown* pUnknown = null
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_SetPrivateDataInterface>(lpVtbl->SetPrivateDataInterface)(
                    This,
                    Name,
                    pUnknown
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPrivateData(
            [In, NativeTypeName("REFGUID")] Guid* Name,
            [In, Out, NativeTypeName("UINT")] uint* pDataSize,
            [Out] void* pData
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetPrivateData>(lpVtbl->GetPrivateData)(
                    This,
                    Name,
                    pDataSize,
                    pData
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetParent(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppParent
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetParent>(lpVtbl->GetParent)(
                    This,
                    riid,
                    ppParent
                );
            }
        }

        public void GetDesc(
            [Out] DXGI_OUTDUPL_DESC* pDesc
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetDesc>(lpVtbl->GetDesc)(
                    This,
                    pDesc
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int AcquireNextFrame(
            [In, NativeTypeName("UINT")] uint TimeoutInMilliseconds,
            [Out] DXGI_OUTDUPL_FRAME_INFO* pFrameInfo,
            [Out] IDXGIResource** ppDesktopResource
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AcquireNextFrame>(lpVtbl->AcquireNextFrame)(
                    This,
                    TimeoutInMilliseconds,
                    pFrameInfo,
                    ppDesktopResource
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameDirtyRects(
            [In, NativeTypeName("UINT")] uint DirtyRectsBufferSize,
            [Out, NativeTypeName("RECT[]")] RECT* pDirtyRectsBuffer,
            [Out, NativeTypeName("UINT")] uint* pDirtyRectsBufferSizeRequired
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameDirtyRects>(lpVtbl->GetFrameDirtyRects)(
                    This,
                    DirtyRectsBufferSize,
                    pDirtyRectsBuffer,
                    pDirtyRectsBufferSizeRequired
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFrameMoveRects(
            [In, NativeTypeName("UINT")] uint MoveRectsBufferSize,
            [Out, NativeTypeName("DXGI_OUTDUPL_MOVE_RECT[]")] DXGI_OUTDUPL_MOVE_RECT* pMoveRectBuffer,
            [Out, NativeTypeName("UINT")] uint* pMoveRectsBufferSizeRequired
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFrameMoveRects>(lpVtbl->GetFrameMoveRects)(
                    This,
                    MoveRectsBufferSize,
                    pMoveRectBuffer,
                    pMoveRectsBufferSizeRequired
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFramePointerShape(
            [In, NativeTypeName("UINT")] uint PointerShapeBufferSize,
            [Out] void* pPointerShapeBuffer,
            [Out, NativeTypeName("UINT")] uint* pPointerShapeBufferSizeRequired,
            [Out] DXGI_OUTDUPL_POINTER_SHAPE_INFO* pPointerShapeInfo
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetFramePointerShape>(lpVtbl->GetFramePointerShape)(
                    This,
                    PointerShapeBufferSize,
                    pPointerShapeBuffer,
                    pPointerShapeBufferSizeRequired,
                    pPointerShapeInfo
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int MapDesktopSurface(
            [Out] DXGI_MAPPED_RECT* pLockedRect
        )
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_MapDesktopSurface>(lpVtbl->MapDesktopSurface)(
                    This,
                    pLockedRect
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int UnMapDesktopSurface()
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_UnMapDesktopSurface>(lpVtbl->UnMapDesktopSurface)(
                    This
                );
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int ReleaseFrame()
        {
            fixed (IDXGIOutputDuplication* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_ReleaseFrame>(lpVtbl->ReleaseFrame)(
                    This
                );
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr SetPrivateData;

            public IntPtr SetPrivateDataInterface;

            public IntPtr GetPrivateData;

            public IntPtr GetParent;

            public IntPtr GetDesc;

            public IntPtr AcquireNextFrame;

            public IntPtr GetFrameDirtyRects;

            public IntPtr GetFrameMoveRects;

            public IntPtr GetFramePointerShape;

            public IntPtr MapDesktopSurface;

            public IntPtr UnMapDesktopSurface;

            public IntPtr ReleaseFrame;
        }
    }
}
