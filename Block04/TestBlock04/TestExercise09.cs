using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise09;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise09
    {
        [TestMethod]
        public void TestToString()
        {
            Time time = new Time(10, 05);
            string res = time.ToString();
            Assert.AreEqual("10:05", res);
        }

        [TestMethod]
        public void TestSumOperation()
        {
            Time time1 = new Time(9, 30);
            Time time2 = new Time(1, 15);
            Time res = time1 + time2;            
            Assert.AreEqual("10:45", res.ToString());
        }

        [TestMethod]
        public void TestSubOperation()
        {
            Time time1 = new Time(9, 30);
            Time time2 = new Time(1, 15);
            Time res = time1 - time2;
            Assert.AreEqual("08:15", res.ToString());
        }

        [TestMethod]
        public void TestConversions()
        {
            Time time1 = new Time(9, 30);
            Time time2 = 120;
            int minutes1 = (int)time1;
            Assert.AreEqual("02:00", time2.ToString());
            Assert.AreEqual(570, minutes1);
        }
    }
}
