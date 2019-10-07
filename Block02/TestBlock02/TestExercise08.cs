using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise08;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise08
    {
        [TestMethod]
        public void TestSum()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3};
            int[] res = SumOfTwoPolYnomials.Sum(a, b);
            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(4, res[1]);
            Assert.AreEqual(6, res[2]);
        }

        [TestMethod]
        public void TestSumWithAMissingElement()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2};
            int[] res = SumOfTwoPolYnomials.Sum(a, b);
            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(4, res[1]);
            Assert.AreEqual(3, res[2]);
        }
    }
}
