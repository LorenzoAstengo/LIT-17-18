using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise05;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise05
    {
        [TestMethod]
        public void TestArray()
        {
            int[] a = { 2, 9, 6, 5, 4, 9, 2, 9, 5, 10, 35 };
            int res = MostCommonElementInArray.FindMostFrequentElement(a);
            Assert.AreEqual(9, res);
        }

        [TestMethod]
        public void TestWithNoRepeatedNUmber()  
        {
            int[] a = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int res = MostCommonElementInArray.FindMostFrequentElement(a);
            Assert.AreEqual(a[0], res);
        }

        [TestMethod]
        public void TestArrayWithOnlyZero()
        {
            int[] a = { 0, 0, 0, 0, 0, 0 };
            int res = MostCommonElementInArray.FindMostFrequentElement(a);
            Assert.AreEqual(0, res);
        }
    }
}
