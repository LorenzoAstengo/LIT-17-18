using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise09;

namespace TestBlock03
{
    [TestClass]
    public class TestExercise09
    {
        [TestMethod]
        public void TestWithGivenExample()
        {
            string text = "We are living in a<upcase> yellow submarine</upcase>.We don't have <upcase>anything</upcase> else.";
            string result = ModifyCasingOfLetters.ToUppercase(text);
            Assert.AreEqual("We are living in a YELLOW SUBMARINE.We don't have ANYTHING else.", result);
        }

        [TestMethod]
        public void TestWithAnotherExample()
        {
            string text = "Ciao come va <upcase>tutto bene</upcase>?.";
            string result = ModifyCasingOfLetters.ToUppercase(text);
            Assert.AreEqual("Ciao come va TUTTO BENE?.", result);
        }
    }
}
