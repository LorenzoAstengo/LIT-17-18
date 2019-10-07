using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using Exercise05;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise05
    {
        [TestMethod]
        public void TestKeyExchange()
        {
            Interlocutor.DHKeyExcange keyExcange = new Interlocutor.DHKeyExcange(23, 5);
            Interlocutor a = new Interlocutor("Alice", 6, keyExcange);
            Interlocutor b = new Interlocutor("Bob", 15, keyExcange);
            BigInteger aPublic = a.GeneratePublicKey();
            BigInteger bPublic = b.GeneratePublicKey();
            BigInteger res = a.GenerateSecretKey(bPublic);
            Assert.AreEqual(2, res);
            Assert.AreEqual(res, b.GenerateSecretKey(aPublic));           
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestException()
        {
            Interlocutor.DHKeyExcange keyExcange = new Interlocutor.DHKeyExcange(17, 3);
            Interlocutor a = new Interlocutor("Mary", 2, keyExcange);
            Interlocutor b = new Interlocutor("Jane", 22, keyExcange);
        }

        [TestMethod]
        public void TestKeyExchange2()
        {
            Interlocutor.DHKeyExcange keyExcange = new Interlocutor.DHKeyExcange(33, 2);
            Interlocutor a = new Interlocutor("Alice", 3, keyExcange);
            Interlocutor b = new Interlocutor("Bob", 20, keyExcange);
            BigInteger aPublic = a.GeneratePublicKey();
            BigInteger bPublic = b.GeneratePublicKey();
            BigInteger res = a.GenerateSecretKey(bPublic);
            Assert.AreEqual(1, res);
            Assert.AreEqual(res, b.GenerateSecretKey(aPublic));
        }
    }
}
