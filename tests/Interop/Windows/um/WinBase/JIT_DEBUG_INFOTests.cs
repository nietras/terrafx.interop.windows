// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="JIT_DEBUG_INFO" /> struct.</summary>
    public static unsafe class JIT_DEBUG_INFOTests
    {
        /// <summary>Validates that the <see cref="JIT_DEBUG_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<JIT_DEBUG_INFO>(), Is.EqualTo(sizeof(JIT_DEBUG_INFO)));
        }

        /// <summary>Validates that the <see cref="JIT_DEBUG_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(JIT_DEBUG_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="JIT_DEBUG_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(JIT_DEBUG_INFO), Is.EqualTo(40));
        }
    }
}