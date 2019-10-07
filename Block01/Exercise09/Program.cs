using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number:");
            bool numberIsANumber = Int32.TryParse(Console.ReadLine(), out Int32 number);
            if (numberIsANumber)
            {
                Console.WriteLine("Insert the position of the bit you want to know:");
                bool pIsaPosition = Int32.TryParse(Console.ReadLine(), out Int32 p);
                if (pIsaPosition)
                {
                    var isSet = (number & (1 << p));

                    Console.WriteLine(isSet != 0 ? "Bit is set." : "Bit is not set");
                }
                else
                {
                    Console.WriteLine("Please insert a correct value (integer)");
                }                
            }
            else
            {
                Console.WriteLine("Please insert a correct value (integer)");
            }            
        }
    }
}
