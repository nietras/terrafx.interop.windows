// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_RAYTRACING_INSTANCE_DESC
    {
        [NativeTypeName("FLOAT [3][4]")]
        public fixed float Transform[3 * 4];

        internal uint _bitfield1;

        [NativeTypeName("UINT : 24")]
        public uint InstanceID
        {
            get
            {
                return _bitfield1 & 0xFFFFFFu;
            }

            set
            {
                _bitfield1 = (_bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
            }
        }

        [NativeTypeName("UINT : 8")]
        public uint InstanceMask
        {
            get
            {
                return (_bitfield1 >> 24) & 0xFFu;
            }

            set
            {
                _bitfield1 = (_bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
            }
        }

        internal uint _bitfield2;

        [NativeTypeName("UINT : 24")]
        public uint InstanceContributionToHitGroupIndex
        {
            get
            {
                return _bitfield2 & 0xFFFFFFu;
            }

            set
            {
                _bitfield2 = (_bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu);
            }
        }

        [NativeTypeName("UINT : 8")]
        public uint Flags
        {
            get
            {
                return (_bitfield2 >> 24) & 0xFFu;
            }

            set
            {
                _bitfield2 = (_bitfield2 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
            }
        }

        [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
        public ulong AccelerationStructure;
    }
}
