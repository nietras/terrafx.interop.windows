// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dcomptypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DCOMPOSITION_DEPTH_MODE
    {
        DCOMPOSITION_DEPTH_MODE_TREE = 0,
        DCOMPOSITION_DEPTH_MODE_SPATIAL = 1,
        DCOMPOSITION_DEPTH_MODE_SORTED = 3,
        DCOMPOSITION_DEPTH_MODE_INHERIT = unchecked((int)0xffffffff),
    }
}
