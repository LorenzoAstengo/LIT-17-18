using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise05;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise05
    {
        [TestMethod]
        public void TestInterval()
        {
            Interval a = new Interval(5, 50);
            Assert.AreEqual(5, a.From);
            Assert.AreEqual(50, a.To);
            Assert.AreEqual(46, a.Length);
        }

        [TestMethod]
        public void TestIntervalExplicit()
        {
            Interval a = new Interval(5, 10);
            int[] res = (int[])a;
            for(int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(res[i], a[i]);
            }            
        }

        [TestMethod]
        public void TestIndexerUp()
        {
            Interval a = new Interval(5, 10);
            int c = 5;
            for(int i = 0; i < a.Length; i++)
            {                
                Assert.AreEqual(c, a[i]);
                c++;
            }            
        }

        [TestMethod]
        public void TestIndexerDown()
        {
            Interval a = new Interval(10, 5);
            int c = 10;
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(c, a[i]);
                c--;
            }
        }

        [TestMethod]
        public void TestIndexerEqual()
        {
            Interval a = new Interval(10, 10);
            int c = 10;
            for (int i = 0; i < a.Length; i++)
            {
                Assert.AreEqual(c, a[i]);
            }
        }
    }
}
