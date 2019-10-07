using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise06;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise06
    {
        [TestMethod]
        public void TestPolinomialCoeffs()
        {
            double[] arr = { 2, 3, 5, 3.2, 5 };
            MyPolinomial polinomial = new MyPolinomial(2, 3, 5, 3.2, 5);
            for(int i = 0; i < arr.Length; i++)
            {
                Assert.AreEqual(arr[i], polinomial.Coeffs[i]);
            }            
        }

        [TestMethod]
        public void TestDegree()
        {
            MyPolinomial polinomial = new MyPolinomial(2, 3, 5, 3.2, 5);
            Assert.AreEqual(4, polinomial.GetDegree());
        }

        [TestMethod]
        public void TestToString()
        {
            MyPolinomial polinomial = new MyPolinomial(2, 3, 5, 3.2, 5);
            string res = polinomial.ToString();
            Assert.AreEqual("5x^4 + 3,2x^3 + 5x^2 + 3x^1 + 2", res);
        }

        [TestMethod]
        public void TestEvaluation()
        {
            MyPolinomial polinomial = new MyPolinomial(2, 3, 5, 3.2, 5);
            Assert.AreEqual(133.6, polinomial.Evaluate(2));
        }

        [TestMethod]
        public void TestAddition()
        {
            double[] res = { 4, 6, 10, 3.2, 10 };
            MyPolinomial polinomial = new MyPolinomial(2, 3, 5, 3.2, 5);
            MyPolinomial polinomial2 = new MyPolinomial(2, 3, 5, 0, 5);
            polinomial.Add(polinomial2);
            for(int i = 0; i < polinomial.Coeffs.Length; i++)
            {
                Assert.AreEqual(res[i], polinomial.Coeffs[i]);
            }            
        }

        [TestMethod]
        public void TestAdditionWithAMajorPolinomial()
        {
            double[] res = { 4, 6, 10, 3.2, 10, 20};
            MyPolinomial polinomial = new MyPolinomial(2, 3, 5, 3.2, 5);
            MyPolinomial polinomial2 = new MyPolinomial(2, 3, 5, 0, 5, 20);
            polinomial.Add(polinomial2);
            for (int i = 0; i < polinomial.Coeffs.Length; i++)
            {
                Assert.AreEqual(res[i], polinomial.Coeffs[i]);
            }
        }

        [TestMethod]
        public void TestAdditionWithAMinorPolinomial()
        {
            double[] res = { 4, 6, 10, 3.2, 5};
            MyPolinomial polinomial = new MyPolinomial(2, 3, 5, 3.2, 5);
            MyPolinomial polinomial2 = new MyPolinomial(2, 3, 5);
            polinomial.Add(polinomial2);
            for (int i = 0; i < polinomial.Coeffs.Length; i++)
            {
                Assert.AreEqual(res[i], polinomial.Coeffs[i]);
            }
        }

        [TestMethod]
        public void TestMultiply()
        {
            double[] res = { 4, 2, 14, 5, 10 };
            MyPolinomial polinomial = new MyPolinomial(2, 0, 5);
            MyPolinomial polinomial2 = new MyPolinomial(2, 1, 2);
            polinomial.Multiply(polinomial2);
            for (int i = 0; i < polinomial.Coeffs.Length; i++)
            {
                Assert.AreEqual(res[i], polinomial.Coeffs[i]);
            }
        }

        [TestMethod]
        public void TestMultiplyWithDifferentLenghts()
        {
            double[] res = { 1, 3, 2, 8, -104, 20 };
            MyPolinomial polinomial = new MyPolinomial(1, 1, 10,-2);
            MyPolinomial polinomial2 = new MyPolinomial(1, 2, -10);
            polinomial.Multiply(polinomial2);
            for (int i = 0; i < polinomial.Coeffs.Length; i++)
            {
                Assert.AreEqual(res[i], polinomial.Coeffs[i]);
            }
        }

    }
}
