using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a four-digit number:");           
            bool numberIsANumber = Int16.TryParse(Console.ReadLine(), out Int16 number);
            if (numberIsANumber)
            {
                int fourthDigit = number / 1000;
                int thirdDigit = (number-(fourthDigit*1000)) / 100;
                int secondDigit = (number- ((fourthDigit * 1000)+(thirdDigit*100))) / 10;
                int firstDigit = (number- ((fourthDigit * 1000) + (thirdDigit * 100)+(secondDigit*10)));

                int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
                Console.WriteLine("Sum of the digits is: {0}", sum);
                Console.WriteLine("Reversed order is: {0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
                Console.WriteLine("Last digit in first position: {0}{3}{2}{1}", firstDigit, secondDigit, thirdDigit, fourthDigit);
                Console.WriteLine("Exchange the second and the third digits: {3}{1}{2}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            }
            else
            {
                Console.WriteLine("Please insert a correct value (four-digit number)");
            }
        }
    }
}
