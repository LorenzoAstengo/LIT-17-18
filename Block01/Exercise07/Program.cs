using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer you want to know whether it is odd or even:");
            var valueIsAnInteger = Int32.TryParse(Console.ReadLine(),out int number);
            if (valueIsAnInteger)
            {
                var remainder = number % 2;

                if (remainder == 0)
                {
                    Console.WriteLine("{0} is a odd.", number);
                }
                else
                {
                    Console.WriteLine("{0} is a even", number);
                }
            }
            else
            {
                Console.WriteLine("Please insert a correct value (integer)");
            }                
        }
    }
}
