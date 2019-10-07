using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise07;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise07
    {
        [TestMethod]
        public void TestNoOrderedArray()
        {
            int n = 5;
            int[] res = RandomArrayOrdered.OrderArray(n);
            Assert.AreNotEqual(1, res[0]);
            Assert.AreNotEqual(2, res[1]);
            Assert.AreNotEqual(3, res[2]);
            Assert.AreNotEqual(4, res[3]);
            Assert.AreNotEqual(5, res[4]);
        }

        [TestMethod]
        public void TestTwoDiffertCall()
        {
            int n = 5;
            int[] res1 = RandomArrayOrdered.OrderArray(n);
            int[] res2 = RandomArrayOrdered.OrderArray(n);
            Assert.AreNotEqual(res1, res2);
        }

        [TestMethod]
        public void TestTwoConsecutiveCall()
        {
            int n = 5;
            int[] res1 = RandomArrayOrdered.OrderArray(n);
            int[] res2 = RandomArrayOrdered.OrderArray(n);
            Assert.AreNotEqual(res1, res2);
        }

        [TestMethod]
        public void TestArrayContainsEveryElement()
        {
            int n = 5;
            int[] res1 = RandomArrayOrdered.OrderArray(n);
            int[] result = new int[res1.Length];
            
            for(int i = 0; i < result.Length; i++)
            {
                for(int j = 0; j < res1.Length; j++)
                {
                   if(res1[j].Equals(i+1))
                    {
                        result[i] = res1[j];
                    }
                }

            }
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(5, result[4]);
        }
    }
}
