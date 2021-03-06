// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum ACTIVATION_CONTEXT_INFO_CLASS
    {
        ActivationContextBasicInformation = 1,
        ActivationContextDetailedInformation = 2,
        AssemblyDetailedInformationInActivationContext = 3,
        FileInformationInAssemblyOfAssemblyInActivationContext = 4,
        RunlevelInformationInActivationContext = 5,
        CompatibilityInformationInActivationContext = 6,
        ActivationContextManifestResourceName = 7,
        MaxActivationContextInfoClass,
        AssemblyDetailedInformationInActivationContxt = 3,
        FileInformationInAssemblyOfAssemblyInActivationContxt = 4,
    }
}
