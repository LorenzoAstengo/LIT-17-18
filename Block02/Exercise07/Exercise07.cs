using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    public class RandomArrayOrdered
    {
        public static int[] OrderArray(int n)
        {
            int prevnumber = 0;            
            int[] a = new int[n];

            for(int i = 0; i <= n - 1; i++)
            {
                a[i] = i + 1;
            }

            Random random = new Random();

            for(int j = n - 1 ; j > 0 ; j--)
            {
                int randomNumber = random.Next(0, j - 1);
                prevnumber = a[j];
                a[j] = a[randomNumber];
                a[randomNumber] = prevnumber;
            }
            return a;
        }
    }
}
