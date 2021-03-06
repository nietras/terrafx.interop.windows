// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D11_BLEND_DESC
    {
        [NativeTypeName("BOOL")]
        public int AlphaToCoverageEnable;

        [NativeTypeName("BOOL")]
        public int IndependentBlendEnable;

        [NativeTypeName("D3D11_RENDER_TARGET_BLEND_DESC [8]")]
        public _RenderTarget_e__FixedBuffer RenderTarget;

        public partial struct _RenderTarget_e__FixedBuffer
        {
            internal D3D11_RENDER_TARGET_BLEND_DESC e0;
            internal D3D11_RENDER_TARGET_BLEND_DESC e1;
            internal D3D11_RENDER_TARGET_BLEND_DESC e2;
            internal D3D11_RENDER_TARGET_BLEND_DESC e3;
            internal D3D11_RENDER_TARGET_BLEND_DESC e4;
            internal D3D11_RENDER_TARGET_BLEND_DESC e5;
            internal D3D11_RENDER_TARGET_BLEND_DESC e6;
            internal D3D11_RENDER_TARGET_BLEND_DESC e7;

            public ref D3D11_RENDER_TARGET_BLEND_DESC this[int index] => ref AsSpan()[index];

            public Span<D3D11_RENDER_TARGET_BLEND_DESC> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
        }
    }
}
