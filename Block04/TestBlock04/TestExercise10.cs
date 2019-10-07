using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise10
    {
        [TestInitialize]
        public void TestArray()
        {
            Employee[] employes = new Employee[4];
            HourlyWorker employee = new HourlyWorker("Beppe", 30);
            HourlyWorker employee2 = new HourlyWorker("Mario", 50);
            SalaryWorker employee3 = new SalaryWorker("Fabio", 25000);
            SalaryWorker employee4 = new SalaryWorker("Gianni", 11520);
            employes[0] = employee;
            employes[1] = employee2;
            employes[2] = employee3;
            employes[3] = employee4;
        }

        [TestMethod]
        public void TestHourlyWorker()
        {
            HourlyWorker worker = new HourlyWorker("Beppe", 30);
            worker.HoursWorked = 200;
            Assert.AreEqual(6000, worker.calcPaidCheck());
        }

        [TestMethod]
        public void TestSalaryWorker()
        {
            SalaryWorker worker = new SalaryWorker("Fabio", 25000);
            Assert.AreEqual(2083.3, worker.calcPaidCheck(),0.1);
        }
    }
}
