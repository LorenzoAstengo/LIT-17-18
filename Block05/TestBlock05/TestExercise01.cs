using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Exercise01;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise01
    {
        [TestMethod]
        public void TestBusTax()
        {
            TaxableBus bus = new TaxableBus(20, 01000, 35255);
            decimal res = bus.TaxValue();
            Assert.AreEqual(7051,res);
        }

        [TestMethod]
        public void TestHouseTax()
        {
            TaxableHouse house = new TaxableHouse("Via all'Opera Pia", true, 250, 220000);
            decimal res = house.TaxValue();
            Assert.AreEqual(33005, res);
        }

        [TestMethod]
        public void TestAreITaxable()
        {
            TaxableBus bus = new TaxableBus(20, 01000, 35255);
            TaxableHouse house = new TaxableHouse("Via all'Opera Pia", true, 250, 220000);
            List<ITaxable> list = new List<ITaxable>();
            try
            {
                list.Add(bus);
                list.Add(house);
            }
            catch(Exception e)
            {
                Assert.Fail("Expected no exception, but got: " + e.Message);
            }
        }
    }
}
