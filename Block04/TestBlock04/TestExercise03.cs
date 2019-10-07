using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise03;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise03
    {
        [TestMethod]
        public void TestCreatingAccount()
        {
            string[] a = { "Lorenzo Astengo", "Marco Rossi" };
            BankAccount account = new BankAccount("Montepaschi", 0.02, 0.003, a, 0, BankAccount.AccountTypes.current);
            Assert.AreEqual( 0, account.CurrentBalance);
            Assert.AreEqual(DateTime.Today, account.OpeningDate);
            Assert.AreEqual("Montepaschi", account.Branch);
            Assert.AreEqual(0.02, account.Rate.Receivable);
            Assert.AreEqual(0.003, account.Rate.Payable);            
            Assert.AreEqual(a, account.Customers);
            Assert.AreEqual(0, account.Utilities);
            Assert.AreEqual(0, account.BankingCosts);
            Assert.AreEqual(1, account.OperationsHistory.Count);
            Assert.AreEqual(BankAccount.AccountTypes.current, account.AccountType);            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNoCustomersException()
        {
            string[] a = { };
            BankAccount account = new BankAccount("Montepaschi", 0.02, 0.003, a, 0, BankAccount.AccountTypes.saving);
        }

        [TestMethod]
        public void TestDeposit()
        {
            string[] a = { "Lorenzo Astengo", "Marco Rossi" };
            BankAccount account = new BankAccount("Montepaschi", 0.02, 0.003, a, 0, BankAccount.AccountTypes.current);
            account.MakeDeposit(2500.25);
            Assert.AreEqual(2, account.OperationsHistory.Count);
            Assert.AreEqual(2500.25, account.CurrentBalance);
        }

        [TestMethod]
        public void TestWithdraw()
        {
            string[] a = { "Lorenzo Astengo", "Marco Rossi" };
            BankAccount account = new BankAccount("Montepaschi", 0.02, 0.003, a, 0, BankAccount.AccountTypes.current);
            account.MakeDeposit(2500.25);
            account.Withdraw(2500.25);
            Assert.AreEqual(3, account.OperationsHistory.Count);
            Assert.AreEqual(0, account.CurrentBalance);
        }

        [TestMethod]
        [ExpectedException(typeof(FieldAccessException))]
        public void TestWithdrawSaving()
        {
            string[] a = { "Lorenzo Astengo", "Marco Rossi" };
            BankAccount account = new BankAccount("Montepaschi", 0.02, 0.003, a, 0, BankAccount.AccountTypes.saving);
            account.MakeDeposit(2500.25);
            account.Withdraw(2500.25);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestWithNegativeWithdraw()
        {
            string[] a = { "Lorenzo Astengo", "Marco Rossi" };
            BankAccount account = new BankAccount("Montepaschi", 0.02, 0.003, a, 0, BankAccount.AccountTypes.current);
            account.MakeDeposit(2500.25);
            account.Withdraw(2600);
        }
    }
}
