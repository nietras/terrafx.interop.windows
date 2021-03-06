// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DISPID_SpeechWaveFormatEx
    {
        DISPID_SWFEFormatTag = 1,
        DISPID_SWFEChannels = (DISPID_SWFEFormatTag + 1),
        DISPID_SWFESamplesPerSec = (DISPID_SWFEChannels + 1),
        DISPID_SWFEAvgBytesPerSec = (DISPID_SWFESamplesPerSec + 1),
        DISPID_SWFEBlockAlign = (DISPID_SWFEAvgBytesPerSec + 1),
        DISPID_SWFEBitsPerSample = (DISPID_SWFEBlockAlign + 1),
        DISPID_SWFEExtraData = (DISPID_SWFEBitsPerSample + 1),
    }
}
