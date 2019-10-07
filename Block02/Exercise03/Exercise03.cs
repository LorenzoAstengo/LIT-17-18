using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class Sorting
    {
        public static int[] SelectionSort(int[] a)
        {      
            for(int i = 0; i < a.Length - 1; i++)
            {
                for(int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] > a[i])
                    {
                        int prev = a[i];
                        a[i] = a[j];
                        a[j] = prev;
                    }                    
                }               
            }
            return a;
        }
    }
}
