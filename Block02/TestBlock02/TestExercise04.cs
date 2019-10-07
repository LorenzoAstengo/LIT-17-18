using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise04
    {      
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), noExceptionMessage: "A=0 must return an exception.")]
        public void TestFirstGradeEquation()
        {
            int a = 0;
            int b = 2;
            int c = 3;
            double[] result = RealRoots.CalculateRealRoots(a, b, c);          
        }

        [TestMethod]        
        public void TestNoRealRoots()
        {
            int a = 4;
            int b = 2;
            int c = 3;
            double[] result = RealRoots.CalculateRealRoots(a, b, c);
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestTwoSameRoots()
        {
            int a = 2;
            int b = 0;
            int c = 0;
            double[] result = RealRoots.CalculateRealRoots(a, b, c);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(0, result[1]);
        }

        [TestMethod]
        public void TestDeltaEqualZero()
        {
            int a = 1;
            int b = 2;
            int c = 1;
            double[] result = RealRoots.CalculateRealRoots(a, b, c);
            Assert.AreEqual(-1, result[0]);
            Assert.AreEqual(-1, result[1]);
        }

        [TestMethod]
        public void TestTwoDifferntRoots()
        {
            int a = 1;
            int b = 0;
            int c = -4;
            double[] result = RealRoots.CalculateRealRoots(a, b, c);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(-2, result[1]);
        }
    }
}
