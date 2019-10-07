using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise01
    {
        [TestMethod]
        public void TestTwoEqualNumbersGreater()
        {
            int a = 2;
            int b = 2;
            int res = TwoNumberComparator.GreaterNumber(a, b);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestTwoEqualNumbersSmaller()
        {
            int a = 2;
            int b = 2;
            int res = TwoNumberComparator.SmallerNumber(a, b);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestOneZeroGreater()
        {
            int a = 2;
            int b = 2;
            int res = TwoNumberComparator.GreaterNumber(a, b);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestOneZeroSmaller()
        {
            int a = 0;
            int b = 2;
            int res = TwoNumberComparator.SmallerNumber(a, b);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestTwoZeroGreater()
        {
            int a = 0;
            int b = 0;
            int res = TwoNumberComparator.GreaterNumber(a, b);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestTwoZeroSmaller()
        {
            int a = 0;
            int b = 0;
            int res = TwoNumberComparator.SmallerNumber(a, b);
            Assert.AreEqual(0, res);
        }
    }
}
