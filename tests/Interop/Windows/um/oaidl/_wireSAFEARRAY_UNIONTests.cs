// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_wireSAFEARRAY_UNION" /> struct.</summary>
    public static unsafe class _wireSAFEARRAY_UNIONTests
    {
        /// <summary>Validates that the <see cref="_wireSAFEARRAY_UNION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_wireSAFEARRAY_UNION>(), Is.EqualTo(sizeof(_wireSAFEARRAY_UNION)));
        }

        /// <summary>Validates that the <see cref="_wireSAFEARRAY_UNION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(_wireSAFEARRAY_UNION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="_wireSAFEARRAY_UNION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(_wireSAFEARRAY_UNION), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(_wireSAFEARRAY_UNION), Is.EqualTo(28));
            }
        }
    }
}
