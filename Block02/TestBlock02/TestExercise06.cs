using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise06;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise06
    {
        [TestMethod]
        public void TestGdc()
        {
            int a = 3;
            int b = 4;
            int res = LcmAndGcd.GCD(a, b);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestLcm()
        {
            int a = 3;
            int b = 4;
            int res = LcmAndGcd.LCM(a, b);
            Assert.AreEqual(12, res);
        }

        [TestMethod]
        public void TestGdcWithZero()
        {
            int a = 0;
            int b = 2;
            int res = LcmAndGcd.GCD(a, b);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestGdcWithTwoZero()
        {
            int a = 0;
            int b = 0;
            int res = LcmAndGcd.GCD(a, b);
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void TestLcmWithTwoZero()
        {
            int a = 0;
            int b = 0;
            int res = LcmAndGcd.LCM(a, b);
            Assert.AreEqual(0, res);
        }
    }
}
