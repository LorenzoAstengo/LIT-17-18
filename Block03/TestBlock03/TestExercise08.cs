using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise08;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise08
    {
        [TestMethod]
        public void TestWithGivenExample()
        {
            string text = "We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
            string substring = "In";
            int res = SearchForASubstring.HowManyTimesRepeated(text, substring);
            Assert.AreEqual(9, res);
        }

        [TestMethod]
        public void TestWithGivenExample2()
        {
            string text = "We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day.We will move out of it in 5 days.";
            string substring = "WE";
            int res = SearchForASubstring.HowManyTimesRepeated(text, substring);
            Assert.AreEqual(4, res);
        }
    }
}
