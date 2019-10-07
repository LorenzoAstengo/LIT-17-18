using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CreatingAndUsingObjects;
using Exercise05;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise05
    {
        [TestMethod]
        public void TestEveryCatIsCatN()
        {
            Cat[] res = CreateCats.Create();
            for(int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual("Cat" + Convert.ToString(i+1), res[i].Name);
            }
        }

        [TestMethod]
        public void TestEveryCatIsCatN2()
        {
            Cat[] res = CreateCats.Create();
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual("Cat" + Convert.ToString(i + 1), res[i].Name);
            }
        }

        [TestMethod]
        public void TestEveryCatIsCatN3()
        {
            Cat[] res = CreateCats.Create();
            for (int i = 0; i < res.Length; i++)
            {
                Assert.AreEqual("Cat" + Convert.ToString(i + 1), res[i].Name);
            }
        }
    }
}
