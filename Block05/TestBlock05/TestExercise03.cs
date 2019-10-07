using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise03;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise03
    {
        [TestMethod]
        public void TestImplicitConversion()
        {
            TriBool res = true;
            Assert.AreEqual(TriBool.States.True,res.State);
            TriBool res2 = false;
            Assert.AreEqual(TriBool.States.False, res2.State);
        }

        [TestMethod]
        public void TestEsplicitConversion()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            bool res = (bool)a;
            TriBool b = new TriBool();
            b.State = TriBool.States.False;
            bool res2 = (bool)b;
            Assert.AreEqual(true, res);
            Assert.AreEqual(false, res2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestInvalidOperation()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.Indeterminate;
            bool res = (bool)a;
        }

        [TestMethod]
        public void TestEqualOperator()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.True;
            var res = (a == b);
            Assert.AreEqual(TriBool.States.True, res.State);
        }

        [TestMethod]
        public void TestEqualOperatorWithDifferent()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.Indeterminate;
            var res = (a == b);
            Assert.AreEqual(TriBool.States.False, res.State);
        }

        [TestMethod]
        public void TestNotEqualOperator()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.True;
            var res = (a != b);
            Assert.AreEqual(TriBool.States.False, res.State);
        }

        [TestMethod]
        public void TestNotEqualOperatorWithDifferent()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.Indeterminate;
            var res = (a != b);
            Assert.AreEqual(TriBool.States.True, res.State);
        }

        [TestMethod]
        public void TestNotOperator()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = !a;
            Assert.AreEqual(TriBool.States.False, b.State);
        }

        [TestMethod]
        public void TestAndOperator()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.Indeterminate;
            TriBool b = new TriBool();
            b.State = TriBool.States.Indeterminate;
            var res = a & b;
            Assert.AreEqual(TriBool.States.True, res.State);
        }

        [TestMethod]
        public void TestAndOperatorDifference()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.False;
            var res = a & b;
            Assert.AreEqual(TriBool.States.False, res.State);
        }

        [TestMethod]
        public void TestOrOperator()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.Indeterminate;
            var res = a | b;
            Assert.AreEqual(TriBool.States.True, res.State);
        }

        [TestMethod]
        public void TestOrOperator2()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.False;
            TriBool b = new TriBool();
            b.State = TriBool.States.Indeterminate;
            var res = a | b;
            Assert.AreEqual(TriBool.States.False, res.State);
        }

        [TestMethod]
        public void TestExorOperator()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.Indeterminate;
            TriBool c = new TriBool();
            c.State = TriBool.States.False;
            var res = a ^ b ^ c;
            Assert.AreEqual(TriBool.States.True, res.State);
        }

        [TestMethod]
        public void TestExorOperator2()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.False;
            TriBool b = new TriBool();
            b.State = TriBool.States.Indeterminate;
            var res = a | b;
            Assert.AreEqual(TriBool.States.False, res.State);
        }

        [TestMethod]
        public void TestNAND()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.True;
            var res = TriBool.NAND(a, b);
            Assert.AreEqual(TriBool.States.False, res.State);
        }

        [TestMethod]
        public void TestNAND2()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.False;
            var res = TriBool.NAND(a, b);
            Assert.AreEqual(TriBool.States.True, res.State);
        }

        [TestMethod]
        public void TestNOR()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            TriBool b = new TriBool();
            b.State = TriBool.States.True;
            var res = TriBool.NOR(a, b);
            Assert.AreEqual(TriBool.States.False, res.State);
        }

        [TestMethod]
        public void TestNOR2()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.False;
            TriBool b = new TriBool();
            b.State = TriBool.States.False;
            var res = TriBool.NAND(a, b);
            Assert.AreEqual(TriBool.States.True, res.State);
        }

        [TestMethod]
        public void TestIsTrue()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.True;
            Assert.AreEqual(true, a.isTrue());
        }

        [TestMethod]
        public void TestIsFalse()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.False;
            Assert.AreEqual(true, a.isFalse());
        }

        [TestMethod]
        public void TestIsIndeterminate()
        {
            TriBool a = new TriBool();
            a.State = TriBool.States.Indeterminate;
            Assert.AreEqual(true, a.isIndeterminate());
        }
    }
}
