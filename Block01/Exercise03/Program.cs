using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number to compare:");
            bool firstValueIsADouble = double.TryParse(Console.ReadLine(), out double firstNumber);

            if (firstValueIsADouble)
            {
                Console.WriteLine("Insert the second number to compare:");
                bool secondValueIsADouble = double.TryParse(Console.ReadLine(), out double secondNumber);

                if (secondValueIsADouble)
                {
                    var equal = Math.Abs(firstNumber - secondNumber) < 0.00001;

                    if (equal == true)
                    {
                        Console.WriteLine("{0} and {1} are equals", firstNumber, secondNumber);
                    }
                    else
                    {
                        if (firstNumber > secondNumber)
                        {
                            Console.WriteLine("{0} is bigger than {1}", firstNumber, secondNumber);
                        }

                        if (firstNumber < secondNumber)
                        {
                            Console.WriteLine("{0} is smaller than {1}", firstNumber, secondNumber);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please insert a correct value!");
                }
            }
            else
            {
                Console.WriteLine("Please insert a correct value!");
            }            
        }
    }
}

