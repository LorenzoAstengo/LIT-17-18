using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class MakeFibonacciSequence
    {
        public static int[] FibonacciSequence(int a)
        {
            int[] seq = new int[a];
            
            if (a < 3 & a != 0) 
            {
                seq[0] = 0;

                for (int i = 1; i < a; i++)
                {
                    seq[i] = 1;
                }
            }
            else if (a != 0) 
            {
                seq[0] = 0;
                seq[1] = 1;
                seq[2] = 1;

                for (int i = 3; i < a; i++)
                {
                    seq[i] = seq[i - 2] + seq[i - 1];
                }
            }            
            return seq;
        }
    }
}
