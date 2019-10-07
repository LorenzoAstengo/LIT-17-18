using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    public class LcmAndGcd
    {
        public static int GCD(int a, int b)
        {
            if (a == 0 && b==0)
            {
                return 0;
            }
            else if (a == 0)
            {
                return b;
            }
            else if (b == 0)
            {
                return a;
            }
            if (a == b)
            {
                return a;
            }
            if (a > b)
            {
                return GCD(a - b, b);
            }
            else
            {
                return GCD(a, b - a);
            }
        }

        public static int LCM(int a, int b)
        {
            if(a==0 && b == 0)
            {
                return 0;
            }
            else
            {
                int result = Math.Abs(a) * Math.Abs(b) / GCD(a, b);
                return result;
            }
        }
    }
}
