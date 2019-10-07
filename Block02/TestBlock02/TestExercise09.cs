using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise09;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise09
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), noExceptionMessage: "B is bigger, method must retorn exception.")]
        public void TestBBiggerThanArrayLenght()
        {
            int[] a = { 1, 3, 0 };
            int b = 4;
            bool res = ElementGreaterThanTwoNeighbors.IsElementGreaterThanTwoNeighbors(a, b);
        }

        [TestMethod]
        public void TestGreaterThanTwoNeighbors()
        {
            int[] a = { 1, 3, 0 };
            int b = 1;
            bool res = ElementGreaterThanTwoNeighbors.IsElementGreaterThanTwoNeighbors(a, b);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestFindPosition()
        {
            int[] a = { 1, 3, 0 };
            int res = ElementGreaterThanTwoNeighbors.PositionOfTheFirstElementGreaterThanTwoNeighbors(a);
            Assert.AreEqual(1, res);
        }

    }
}
