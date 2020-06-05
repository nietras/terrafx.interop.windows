// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="LASTINPUTINFO" /> struct.</summary>
    public static unsafe class LASTINPUTINFOTests
    {
        /// <summary>Validates that the <see cref="LASTINPUTINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<LASTINPUTINFO>(), Is.EqualTo(sizeof(LASTINPUTINFO)));
        }

        /// <summary>Validates that the <see cref="LASTINPUTINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(LASTINPUTINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="LASTINPUTINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(LASTINPUTINFO), Is.EqualTo(8));
        }
    }
}
