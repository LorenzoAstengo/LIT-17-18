using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public abstract class Employee
    {
        private string empName;
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public Employee(string empName)
        {
            this.empName = empName;
        }

        public abstract double calcPaidCheck();        
    }

    public class HourlyWorker : Employee
    {
        private double hourlyRate;
        public double HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
        private int hoursWorked;
        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        public HourlyWorker(string empName, double hourlyRate) : base(empName)
        {
            this.hourlyRate = hourlyRate;
        }
        public override double calcPaidCheck()
        {
            return hourlyRate * hoursWorked;
        }
    }

    public class SalaryWorker : Employee
    {
        private double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public SalaryWorker(string empName, double salary) : base(empName)
        {
            this.salary = salary;
        }
        public override double calcPaidCheck()
        {
            return salary / 12;
        }
    }
}
