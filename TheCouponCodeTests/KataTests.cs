using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheCouponCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCouponCode.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod]
        public void ValidCoupon()
        {
            Assert.AreEqual(true, Kata.CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
        }

        [TestMethod]
        public void InvalidCoupon()
        {
            Assert.AreEqual(false, Kata.CheckCoupon("123a", "123", "September 5, 2014", "October 1, 2014"));
        }

        [TestMethod]
        public void ExpiredCoupon()
        {
            Assert.AreEqual(false, Kata.CheckCoupon("123", "123", "November 5, 2014", "October 1, 2014"));
        }
    }
}