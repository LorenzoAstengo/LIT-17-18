using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a [x,y] type point to know if it is part of the circle K[(0,0);R=5]");
            Console.WriteLine("Insert x:");
            bool aIsAFloat = float.TryParse(Console.ReadLine(), out float a);

            if (aIsAFloat)
            {
                Console.WriteLine("Insert y:");
                bool bIsAFloat = float.TryParse(Console.ReadLine(), out float b);

                if (bIsAFloat)
                {
                    if ((a * a) + (b * b) <= 25)
                    {
                        Console.WriteLine("The point: [{0};{1}] is within the circle K[(0,0);R=5]", a, b);
                    }
                    else
                    {
                        Console.WriteLine("The point: [{0};{1}] is not within the circle K[(0,0),R = 5]", a, b);
                    }
                }
                else
                {
                    Console.WriteLine("Please insert a correct value (float)");
                }                
            }
            else
            {
                Console.WriteLine("Please insert a correct value (float)");
            }
        }
    }
}
