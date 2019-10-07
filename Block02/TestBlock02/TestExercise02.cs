using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise02
    {
        [TestMethod]
        public void TestWithZero()
        {
            int a = 0;
            int[] res = MakeFibonacciSequence.FibonacciSequence(a);
            Assert.AreEqual(0, res.Length);
        }

        [TestMethod]
        public void TestWithThree()
        {
            int a = 3;
            int[] res = MakeFibonacciSequence.FibonacciSequence(a);
            Assert.AreEqual(3, res.Length);
            Assert.AreEqual(0, res[0]);
            Assert.AreEqual(1, res[1]);
            Assert.AreEqual(1, res[2]);
        }

        [TestMethod]
        public void TestWith20()
        {
            int a = 20;
            int[] res = MakeFibonacciSequence.FibonacciSequence(a);
            Assert.AreEqual(20, res.Length);
            Assert.AreEqual(4181, res[19]);
        }

        [TestMethod]                                //Aggiungo anche un test più completo che verifichi che davvero i numeri ottenuti rispettino la definizione di numeri di Fibonacci
        public void TestFibonacciSequence()
        {
            int a = 20;
            int[] res = MakeFibonacciSequence.FibonacciSequence(a);
            Assert.AreEqual(res[19], res[17] + res[18]);
            for(int i = 19; i >= 2; i--) 
            {
                Assert.AreEqual(res[i], res[i - 2] + res[i - 1]);
            }
        }
    }
}
