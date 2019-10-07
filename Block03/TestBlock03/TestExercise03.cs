using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise03;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise03
    {
        [TestMethod]
        public void TestWithGivenStrings()
        {
            string a = "aaaaabbbbbcdddeeeedssaa";
            string res = RepeatedLetters.EliminateRepeatedLetters(a);
            Assert.AreEqual("abcdedsa", res);
        }

        [TestMethod]
        public void TestWithGivenStrings2()
        {
            string a = "ccccciiiaaaao";
            string res = RepeatedLetters.EliminateRepeatedLetters(a);
            Assert.AreEqual("ciao", res);
        }

        [TestMethod]
        public void TestWithGivenStrings3()
        {
            string a = "aaaaaaaaaaaaaaaaaa";
            string res = RepeatedLetters.EliminateRepeatedLetters(a);
            Assert.AreEqual("a", res);
        }
    }
}
