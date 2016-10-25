using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreTheyTheSame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace AreTheyTheSame.Tests
{
    [TestClass()]
    public class AreTheySameTests
    {
        [TestMethod()]
        public void ShouldFailWhenAIsNull()
        {
            AreTheySame.comp(null, new int[1]).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldFailWhenBIsNull()
        {
            AreTheySame.comp(new int[1], null).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldSucceedWhenBothArraysAreEmpty()
        {
            AreTheySame.comp(new int[0], new int[0]).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldFailWhenDifferentLengths()
        {
            AreTheySame.comp(new int[1], new int[2]).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldSucceedWhenArraysValid()
        {
            var a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            var b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            AreTheySame.comp(a, b).Should().BeTrue();
        }

        [TestMethod]
        public void ShouldFailWhenArraysInvalid()
        {
            var a = new int[] { 123, 144, 19, 161, 19, 144, 19, 11 };
            var b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            AreTheySame.comp(a, b).Should().BeFalse();
        }

        [TestMethod]
        public void ShouldSucceedWhenArraysValidAndContainNegativeNumbers()
        {
            var a = new int[] { -121, 144, 19, 161, -19, 144, 19, -11 };
            var b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            AreTheySame.comp(a, b).Should().BeTrue();
        }
    }
}