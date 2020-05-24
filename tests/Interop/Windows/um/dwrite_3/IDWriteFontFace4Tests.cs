// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteFontFace4" /> struct.</summary>
    public static class IDWriteFontFace4Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteFontFace4" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteFontFace4).GUID, Is.EqualTo(IID_IDWriteFontFace4));
        }

        /// <summary>Validates that the layout of the <see cref="IDWriteFontFace4" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteFontFace4).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IDWriteFontFace4" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IDWriteFontFace4>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IDWriteFontFace4>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IDWriteFontFace4.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IDWriteFontFace4" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IDWriteFontFace4.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IDWriteFontFace4" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IDWriteFontFace4.Vtbl>(), Is.EqualTo(424));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IDWriteFontFace4.Vtbl>(), Is.EqualTo(212));
                }
            }
        }
    }
}