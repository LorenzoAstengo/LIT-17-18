using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrototypeExercise;

namespace PrototypeTest
{
    [TestClass]
    public class TestExercise04
    {
        [TestMethod]
        public void TestSimpleClone()
        {
            Developer dev = new Developer();
            dev.Name = "Mike";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "James"; //Not mention Role and PreferredLanguage, it will copy above

            Assert.AreEqual("Mike", dev.Name);
            Assert.AreEqual("James", devCopy.Name);
            Assert.AreEqual("Team Leader", dev.Role);
            Assert.AreEqual("Team Leader", devCopy.Role);
            Assert.AreEqual("C#", dev.PreferredLanguage);
            Assert.AreEqual("C#", devCopy.PreferredLanguage);
        }
        [TestMethod]
        public void TestAddressClone()
        {
            Developer dev = new Developer();
            dev.Name = "Mike";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";
            dev.Address = new Address { Street = "Via all'Opera Pia 11", ZIPCode = "16145", Town = "Genova", Country = "Italy" };

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "James"; //Not mention Role and PreferredLanguage, it will copy above
            devCopy.Address.Street = "Corso Buenos Aires";

            Assert.AreEqual("Corso Buenos Aires", devCopy.Address.Street);
            Assert.AreEqual("Via all'Opera Pia 11", dev.Address.Street);
        }

        [TestMethod]
        public void TestIterateEmployees()
        {
            Company comp = new Company();
            comp.FillCollection();
            string[] nameArr = new string[4];
            int i = 0;
            foreach (Employee emp in comp)
            {
                nameArr[i] = emp.Name;
                i++;
            }
            string[] nameArrExpected = new string[] { "John", "Paul", "Elisabeth", "Mark" };
            CollectionAssert.AreEqual(nameArrExpected, nameArr);
        }
    }
}
