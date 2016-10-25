using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhichAreIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhichAreIn.Tests
{
    [TestClass()]
    public class WhichAreInTests
    {
        [TestMethod()]
        public void TestinArrayShouldReturnSame()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };

            var result = WhichAreIn.inArray(a1, a2);

            CollectionAssert.AreEqual(r, result);
        }

        [TestMethod()]
        public void TestinArrayShouldReturnEmpty()
        {
            string[] a1 = new string[] { "tarp", "mice", "bull" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[0];
            CollectionAssert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }

        [TestMethod]
        public void TestInArrayShouldReturnSorted()
        {
            string[] a1 = new string[] { "strong", "live", "arp" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };

            var result = WhichAreIn.inArray(a1, a2);

            CollectionAssert.AreEqual(r, result);
        }
    }
}