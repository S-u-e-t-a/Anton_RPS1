using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using firstLab;

namespace UnitTestLab1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodUsualArray()
        {
            int[] arr = { -1, 1, -2, 4, -3 };
            Counting test = new Counting();
            int res = test.CountNegative(arr);

            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestMethodAllNegative()
        {
            int[] arr = { -1, -4, -2 };
            Counting test = new Counting();
            int res = test.CountNegative(arr);

            Assert.AreEqual(-1, res);
        }

        [TestMethod]
        public void TestMethodAllPositive()
        {
            int[] arr = { 7, 30, 4 };
            Counting test = new Counting();
            int res = test.CountNegative(arr);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethodAllZero()
        {
            int[] arr = { 0, 0, 0 };
            Counting test = new Counting();
            int res = test.CountNegative(arr);

            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestMethodMaxIsFirst()
        {
            int[] arr = { 10, -60, -12 };
            Counting test = new Counting();
            int res = test.CountNegative(arr);

            Assert.AreEqual(0, res);
        }
    }
}
