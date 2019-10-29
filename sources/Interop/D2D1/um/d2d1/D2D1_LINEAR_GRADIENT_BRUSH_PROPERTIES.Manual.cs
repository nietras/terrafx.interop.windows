// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES
    {
        public D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES(in D2D_POINT_2F startPoint, in D2D_POINT_2F endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }
    }
}
