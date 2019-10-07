using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace TestBlock02
{
    [TestClass]
    public class TestExercise10
    {
        [TestMethod]
        public void TestWithGivenExample()
        {
            string a = "Test";
            string code = "ab";
            char[] res = Encryption.EncryptText(a, code);
            Assert.AreEqual('\u0035', res[0]);
        }

        [TestMethod]
        public void TestWithOthersStrings()
        {
            string text = "Questo messaggio verrà criptato";
            string code = "abcdefghijklmnopqrstuvz0123456789";
            char[] res = Encryption.EncryptText(text, code);
            char[] reconvertedText = new char[text.Length];
            int c = 0;
            for(int i = 0; i < res.Length; i++)
            {
                reconvertedText[i] = Convert.ToChar((res[i])^(code[c]));
                c++;
                if (c == code.Length)
                {
                    c = 0;
                }
            }
            for(int j = 0; j < text.Length; j++)
            {
                Assert.AreEqual(text[j],reconvertedText[j]);
            }
            
        }
    }
}
