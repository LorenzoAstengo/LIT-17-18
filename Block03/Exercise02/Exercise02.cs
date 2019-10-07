using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    public class SumOfTwoIntegerLong
    {
        public static int[] Sum(int[] a, int[] b)
        {

            bool aIsBigger = a.Length > b.Length;
            if (aIsBigger)
            {
                int[] res = new int[a.Length + 1];
                res[0] = (a[0] + b[0]) % 10;
                for (int i = 1; i < a.Length; i++)
                {
                    if (i < b.Length)
                    {
                        res[i] = (a[i] + b[i]) % 10 + ((a[i - 1] + b[i - 1]) / 10);
                    }
                    else
                    {
                        res[i] = a[i];
                    }
                }
                return res;
            }
            else
            {
                int[] res = new int[b.Length + 1];
                res[0] = (a[0] + b[0]) % 10;
                for (int i = 1; i < b.Length; i++)
                {
                    if (i < a.Length)
                    {
                        res[i] = (a[i] + b[i]) % 10 + ((a[i - 1] + b[i - 1]) / 10);
                    }
                    else
                    {
                        res[i] = b[i];
                    }
                }
                return res;
            }
        }
    }
}