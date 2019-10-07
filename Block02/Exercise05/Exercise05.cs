using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    public class MostCommonElementInArray
    {
        //Nel caso in cui l'array inserito contenga più numeri con la stessa frequenza viene restituito il primo elemento.
        public static int FindMostFrequentElement(int[] a)      
        {
            int[] numbers = new int[a.Length];      
            int[] frequences = new int[a.Length];

            for(int i = 0; i < a.Length; i++)
            {
                bool isInNumbers = (numbers.Contains(a[i]));
                if (isInNumbers is false)
                {
                    numbers[i] = a[i];
                }                
            }

             for(int j = 0; j < numbers.Length; j++)
             {
                for(int k = 0; k < a.Length; k++)
                {
                    if (numbers[j] == a[k])
                    {
                        frequences[j]++;
                    }                         
                }
             }
             int res = numbers[Array.IndexOf(frequences, frequences.Max())];
             return res;

/*----------Altro metodo con eccezione nel caso in cui non ci siano elementi ripetuti--------*/
            /*int count = 0;
            int max = 0;
            int number = 0;*/

                      
            /*for (int i=0; i <= a.Length - 1; i++) 
            {
                for(int j=0; j <= a.Length - 1; j++)
                {
                    if (a[j] == a[i])
                    {
                        count++;
                    }
                }
                if (count > max & count != 1) 
                {
                    max = count;
                    number = a[i];
                }                
                count = 0;               
            }
            if (max == 0)
            {
                throw new Exception("No repeated element in array");
            }
            else
            {
                return number;
            }*/         
        }
    }
}
