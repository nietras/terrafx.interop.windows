// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D11_MAPPED_SUBRESOURCE
    {
        [NativeTypeName("void *")]
        public void* pData;

        [NativeTypeName("UINT")]
        public uint RowPitch;

        [NativeTypeName("UINT")]
        public uint DepthPitch;
    }
}