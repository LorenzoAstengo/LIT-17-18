using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    public class TwoNumberComparator
    {
        public static int GreaterNumber(int a, int b)
        {
            int result = a * Convert.ToInt16(a >= b) + b * Convert.ToInt16(b > a);  
            return result;
        }

        public static int SmallerNumber(int a, int b)
        {
            int result = a * Convert.ToInt16(a <= b) + b * Convert.ToInt16(b < a);
            return result;
        }
    }
}

