using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise04;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise04
    {
        [TestMethod]
        public void TestMyComplex()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            Assert.AreEqual(2.2, complex.Real);
            Assert.AreEqual(3, complex.Imaginary);
        }

        [TestMethod]
        public void TestMyComplexToString()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            Assert.AreEqual(2.2, complex.Real);
            Assert.AreEqual(3, complex.Imaginary);
            string res = complex.ToString();
            Assert.AreEqual("(2,2+3i)", res);
        }

        [TestMethod]
        public void TestIsReal()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            bool res = complex.IsReal();
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void TestIsReal2()
        {
            MyComplex complex = new MyComplex(2.2, 0);
            bool res = complex.IsReal();
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestIsImaginary()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            bool res = complex.IsImaginary();
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void TestIsImaginary2()
        {
            MyComplex complex = new MyComplex(0, 3);
            bool res = complex.IsImaginary();
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestAreEquals()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            bool res = complex.Equals(2.2, 3);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestAreEquals2()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            MyComplex complex2 = new MyComplex(2, 3);
            bool res = complex.Equals(complex2);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void TestAreEquals3()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            MyComplex complex2 = new MyComplex(2.2, 3);
            bool res = complex.Equals(complex2);
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void TestMagnitude()
        {
            MyComplex complex = new MyComplex(1, 2);
            double res = complex.Magnitude();
            Assert.AreEqual(Math.Sqrt(5),res);
        }

        [TestMethod]
        public void TestArguments()
        {
            MyComplex complex = new MyComplex(2, 2*(Math.Sqrt(3)));
            double res = complex.Argument();
            Assert.AreEqual((Math.PI)/3,res);
        }

        [TestMethod]
        public void TestAdd()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            MyComplex complex2 = new MyComplex(2, 3);
            complex.Add(complex2);
            Assert.AreEqual(4.2, complex.Real);
            Assert.AreEqual(6, complex.Imaginary);
        }

        [TestMethod]
        public void TestSub()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            MyComplex complex2 = new MyComplex(3.2, 5);
            complex.Subtract(complex2);
            Assert.AreEqual(-1, complex.Real);
            Assert.AreEqual(-2, complex.Imaginary);
        }

        [TestMethod]
        public void TestMultiply()
        {
            MyComplex complex = new MyComplex(2, 5);
            MyComplex complex2 = new MyComplex(2, 3);
            complex.Multiply(complex2);
            Assert.AreEqual(-11, complex.Real);
            Assert.AreEqual(16, complex.Imaginary);
        }

        [TestMethod]
        public void TestDivide()
        {
            MyComplex complex = new MyComplex(2, 9);
            MyComplex complex2 = new MyComplex(2, 3);
            complex.Add(complex2);
            Assert.AreEqual(4, complex.Real);
            Assert.AreEqual(12, complex.Imaginary);
        }

        [TestMethod]
        public void TestConjugate()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            complex.Conjugate();
            Assert.AreEqual(2.2, complex.Real);
            Assert.AreEqual(-3, complex.Imaginary);
        }

        [TestMethod]
        public void TestOperatorDifferent()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            MyComplex complex2 = new MyComplex(2.2, 3);
            MyComplex complex3 = new MyComplex(4, 3);
            Assert.IsTrue(complex != complex3);
            Assert.IsFalse(complex != complex2);
        }

        [TestMethod]
        public void TestOperatorEqual()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            MyComplex complex2 = new MyComplex(2.2, 3);
            MyComplex complex3 = new MyComplex(4, 3);
            Assert.IsTrue(complex == complex2);
            Assert.IsFalse(complex == complex3);
        }

        [TestMethod]
        public void TestOperatorSum()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            MyComplex complex2 = new MyComplex(2.2, 3);
            MyComplex complex3 = new MyComplex(4.4, 6);
            MyComplex res = complex + complex2;
            Assert.AreEqual(res.Real, complex3.Real);
            Assert.AreEqual(res.Imaginary, complex3.Imaginary);
        }

        [TestMethod]
        public void TestOperatorDifference()
        {
            MyComplex complex = new MyComplex(2.2, 3);
            MyComplex complex2 = new MyComplex(2.2, 3);
            MyComplex complex3 = new MyComplex(0, 0);
            MyComplex res = complex - complex2;
            Assert.AreEqual(res.Real, complex3.Real);
            Assert.AreEqual(res.Imaginary, complex3.Imaginary);
        }

        [TestMethod]
        public void TestOperatorMultiply()
        {
            MyComplex complex = new MyComplex(2, 3);
            MyComplex complex2 = new MyComplex(3, 2);
            MyComplex complex3 = new MyComplex(0, 13);
            MyComplex res = complex * complex2;
            Assert.AreEqual(res.Real, complex3.Real);
            Assert.AreEqual(res.Imaginary, complex3.Imaginary);
        }

        [TestMethod]
        public void TestOperatorDivide()
        {
            MyComplex complex = new MyComplex(2, 3);
            MyComplex complex2 = new MyComplex(3, 2);
            MyComplex complex3 = new MyComplex(12/13, 5/13);
            MyComplex res = complex / complex2;
            Assert.AreEqual(res.Real, complex3.Real,0.95);
            Assert.AreEqual(res.Imaginary, complex3.Imaginary,0.4);
        }
    }
}
