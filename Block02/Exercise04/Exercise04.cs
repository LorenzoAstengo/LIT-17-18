using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    public class RealRoots
    {
        public static double[] CalculateRealRoots(int a, int b, int c)
        {
            double[] results = new double[2];
            if (a != 0)
            {
                double delta = b * b - 4 * a * c;
                /*if (delta == 0)                               //ho notato che mettendo delta >= 0 nell'if successivo posso eliminare questo if
                {
                    results[0] = (b + Math.Sqrt(delta)) / 2;
                    results[1] = results[0];
                    return results;
                }
                else*/
                if (delta >= 0)
                {
                    results[0] = (-b + Math.Sqrt(delta)) / 2 * a;
                    results[1] = (-b - Math.Sqrt(delta)) / 2 * a;
                    return results;
                }
                else
                {
                    results = null;
                    return results;
                }
            }
            else
            {
                throw new ArgumentException("Not a second grade equation, division by zero", "a = 0");
            }           
        }
    }
}
