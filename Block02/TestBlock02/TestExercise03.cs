using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise03;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise03
    {
        [TestMethod]
        public void TestSorting()
        {
            int[] a = { 4, 10, 5, 9};
            int[] res = Sorting.SelectionSort(a);
            Assert.AreEqual(10, res[0]);
            Assert.AreEqual(9, res[1]);
            Assert.AreEqual(5, res[2]);
            Assert.AreEqual(4, res[3]);
        }

        [TestMethod]
        public void TestSortingWithZero()
        {
            int[] a = {0,0,0,0};
            int[] res = Sorting.SelectionSort(a);
            Assert.AreEqual(0, res[0]);
            Assert.AreEqual(0, res[1]);
            Assert.AreEqual(0, res[2]);
            Assert.AreEqual(0, res[3]);
        }
    }
}
