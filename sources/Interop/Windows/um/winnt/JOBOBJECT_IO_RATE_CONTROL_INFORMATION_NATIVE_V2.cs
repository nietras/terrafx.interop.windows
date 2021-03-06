// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct JOBOBJECT_IO_RATE_CONTROL_INFORMATION_NATIVE_V2
    {
        [NativeTypeName("LONG64")]
        public long MaxIops;

        [NativeTypeName("LONG64")]
        public long MaxBandwidth;

        [NativeTypeName("LONG64")]
        public long ReservationIops;

        [NativeTypeName("PWSTR")]
        public ushort* VolumeName;

        [NativeTypeName("DWORD")]
        public uint BaseIoSize;

        public JOB_OBJECT_IO_RATE_CONTROL_FLAGS ControlFlags;

        [NativeTypeName("WORD")]
        public ushort VolumeNameLength;

        [NativeTypeName("LONG64")]
        public long CriticalReservationIops;

        [NativeTypeName("LONG64")]
        public long ReservationBandwidth;

        [NativeTypeName("LONG64")]
        public long CriticalReservationBandwidth;

        [NativeTypeName("LONG64")]
        public long MaxTimePercent;

        [NativeTypeName("LONG64")]
        public long ReservationTimePercent;

        [NativeTypeName("LONG64")]
        public long CriticalReservationTimePercent;
    }
}
