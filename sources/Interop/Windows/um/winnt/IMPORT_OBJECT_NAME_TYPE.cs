// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum IMPORT_OBJECT_NAME_TYPE
    {
        IMPORT_OBJECT_ORDINAL = 0,
        IMPORT_OBJECT_NAME = 1,
        IMPORT_OBJECT_NAME_NO_PREFIX = 2,
        IMPORT_OBJECT_NAME_UNDECORATE = 3,
        IMPORT_OBJECT_NAME_EXPORTAS = 4,
    }
}
