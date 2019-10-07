using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 12;

            Console.WriteLine("Valore di a:{0}\nValore di b:{1}", a, b);
            int oldA = a;
            a = b;
            b = oldA;
            Console.WriteLine("Nuovo valore di a:{0}\nNuovo valore di b:{1}", a, b);
        }
    }
}
