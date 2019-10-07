using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class SumOfTwoPolYnomials
    {
        public static int[] Sum(int[] a, int[] b)
        {
            int maxcoeff = Math.Max(a.Length, b.Length);
            int[] result = new int[maxcoeff];
            
            for (int i = 0; i < maxcoeff; i++)
            {
                if (i > a.Length - 1) 
                {
                    result[i] = b[i];
                }
                else if (i > b.Length - 1)
                {
                    result[i] = a[i];
                }
                else
                {
                    result[i] = a[i] + b[i];
                }
            }
            return result;
        }
    }
}
