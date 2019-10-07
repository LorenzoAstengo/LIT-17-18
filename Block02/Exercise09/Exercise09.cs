using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public class ElementGreaterThanTwoNeighbors
    {
        public static bool IsElementGreaterThanTwoNeighbors(int[] a,int b)
        {
            if (b > a.Length)
            {
                throw new Exception("Position inserted is bigger than array lenght");
            }
            else if (b == 0)
            {
                bool isGreater = a[b] > a[b + 1];
                return isGreater;
            }
            else if (b == a.Length)
            {
                bool isGreater = a[b] > a[b - 1];
                return isGreater;
            }
            else
            {
                bool isGreater = (a[b] > a[b - 1] & a[b] > a[b + 1]);
                return isGreater;
            }
        }

        public static int PositionOfTheFirstElementGreaterThanTwoNeighbors(int[] a)
        {
            var c = false;
            int i = -1;
            while (c is false && i < a.Length) 
            {
                i++;
                c = IsElementGreaterThanTwoNeighbors(a, i);                
            }
            return i;       
        }
    }
}
