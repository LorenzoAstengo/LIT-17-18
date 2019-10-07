using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise02
    {
        [TestMethod]
        public void TestSum1()
        {
            int[] a = { 0, 0, 0, 0, 2, 10, 1, 0, 3 };
            int[] b = { 0, 0, 0, 0, 0, 9, 0, 2 };
            int[] res = SumOfTwoIntegerLong.Sum(a, b);
            int[] correctres = { 0, 0, 0, 0, 2, 9, 2, 2, 3, 0 };
            for(int i = 0; i < correctres.Length; i++)
            {
                Assert.AreEqual(correctres[i], res[i]);
            }            
        }

        [TestMethod]
        public void TestSum2()
        {
            int[] a = { 1, 0, 3, 5, 10, 4 };
            int[] b = { 0, 2, 5, 5, 3, 0 };
            int[] res = SumOfTwoIntegerLong.Sum(a, b);
            int[] correctres = { 1, 2, 8, 0, 4, 5 };
            for (int i = 0; i < correctres.Length; i++)
            {
                Assert.AreEqual(correctres[i], res[i]);
            }
        }
    }
}
