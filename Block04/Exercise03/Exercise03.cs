using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class BankAccount
    {
        private double currentBalance;
        public double CurrentBalance
        {
            get { return currentBalance; }
            set { currentBalance = value; }
        }
        private DateTime openingDate;
        public DateTime OpeningDate
        {
            get { return openingDate; }
            set { openingDate = value; }
        }
        private string branch;
        public string Branch
        {
            get { return branch; }
            set { branch = value; }
        }
        public class InterestRate
        {
            private double receivable;
            private double payable;

            public double Receivable
            {
                get { return receivable; }
                set { receivable = value; }
            }
            public double Payable
            {
                get { return payable; }
                set { payable = value; }
            }

            public InterestRate(double receivable, double payable)
            {
                this.receivable = receivable;
                this.payable = payable;
            }
        }
        private InterestRate rate;
        public InterestRate Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        private string[] customers;
        public string[] Customers
        {
            get { return customers; }
            set { customers = value; }
        }
        private double utilities;
        public double Utilities
        {
            get { return utilities; }
            set { utilities = value; }
        }
        private double bankingCosts;  
        public double BankingCosts
        {
            get { return bankingCosts; }
            set { bankingCosts = value; }
        }
        public class Operation
        {
            private DateTime operationDate;
            private string operationComment;

            public DateTime OperationDate
            {
                get { return operationDate; }
                set { operationDate = value; }
            }

            public string OperationComment
            {
                get { return operationComment; }
                set { operationComment = value; }
            }

            public Operation(string comment)
            {
                operationDate = DateTime.Today;
                operationComment = comment;
            }
        }
        private List<Operation> operationsHistory = new List<Operation>();
        public List<Operation> OperationsHistory
        {
            get { return operationsHistory; }
            set { operationsHistory = value; }
        }
        public enum AccountTypes { saving, current };
        private AccountTypes accountType;
        public AccountTypes AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public BankAccount(string branch, double receivableRate, double payableRate, string[] customers, double bankingcosts, AccountTypes type)
        {
            currentBalance = 0;
            openingDate = DateTime.Today;
            this.branch = branch;
            InterestRate rate = new InterestRate(receivableRate, payableRate);
            this.rate = rate;
            if (customers.Length >= 1)
            {
                this.customers = customers;
            }
            else
            {
                throw new ArgumentException();
            }            
            utilities = 0;
            this.bankingCosts = bankingcosts;
            Operation operation = new Operation("Account created.");
            operationsHistory.Add(operation);
            accountType = type;
        }

        public void MakeDeposit(double value)
        {
            currentBalance = currentBalance + value;
            Operation operation = new Operation("Deposit of"+ value+"€.");
            operationsHistory.Add(operation);
        }

        public void Withdraw(double value)
        {
            if (accountType == AccountTypes.current)
            {
                if (currentBalance >= value)
                {
                    currentBalance = currentBalance - value;
                    Operation operation = new Operation("Withdraw of" + value + "€.");
                    operationsHistory.Add(operation);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            else
            {
                throw new FieldAccessException();
            }
        }

        public void TransferMoney(BankAccount account1, BankAccount account2, Double value)
        {
            account1.Withdraw(value);
            account2.MakeDeposit(value);            
        }
    }
}
