using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 27560000;
            int scelta = -1;

            List<employee> employees = new List<employee>();

            while (scelta != 0)
            {
                Console.WriteLine("Press 1 to insert a new employee");
                Console.WriteLine("Press 2 to view employes");
                Console.WriteLine("Press 0 to exit");
                scelta = Convert.ToInt16(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Insert employee's first name:");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Insert employee's last name:");
                        string secondname = Console.ReadLine();
                        Console.WriteLine("Insert employee's age:");
                        byte age = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("Insert employee's gender: [m for male, f for female]");
                        char gender =Convert.ToChar(Console.ReadLine());

                        employee Employee = new employee(counter, firstname, secondname, age, gender);
                        employees.Add(Employee);
                        counter++;
                        break;

                    case 2:
                        Console.Clear();
                        foreach(employee a in employees)
                        {
                            Console.WriteLine("Employee's Id Number: {0}", a.IdNumber);
                            Console.WriteLine("Employee's First Name: {0}", a.FirstName);
                            Console.WriteLine("Employee's Second Name: {0}", a.LastName);
                            Console.WriteLine("Employee's Age: {0}", a.Age);
                            Console.WriteLine("Employee's Gender: {0}", a.Gender);
                            Console.WriteLine("\n");
                        }
                       
                        break;
                }
            }
        }
    }

    public class employee
    {
        private string firstName;
        private string lastName;
        private byte age;
        private char gender;
        private int idNumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public byte Age
        {
            get { return age; }
            set { age = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        public employee(int IDNUMBER,string FIRSTNAME,string LASTNAME,byte AGE,char GENDER)
        {
            idNumber = IDNUMBER;
            firstName = FIRSTNAME;
            lastName = LASTNAME;
            age = AGE;
            gender = GENDER;
        }
    }
}
