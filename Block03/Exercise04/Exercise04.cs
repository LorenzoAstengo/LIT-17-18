using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace Exercise04
{
    public class FindSubsets
    {
        static string[] subsetArr;
        static int n;
        public static string[] Subsets(int subsetsLenght, string[] words)
        {
            n = 0;
            int lenght = (Factorial(words.Length)) / (Factorial(subsetsLenght) * Factorial(words.Length - subsetsLenght));
            subsetArr = new string[lenght];
            int[] arr = new int[subsetsLenght];
            Find(arr, 0, 0, words.Length, words);
            return subsetArr;
        }
        private static int Factorial(int n)
        {
            int factorial = n;
            for (int i = n - 1; i > 1; i--)
            {
                factorial = factorial * i;
            }
            if (factorial == 0)
                return 1;
            else
                return factorial;
        }
        private static void Find(int[] arr, int index, int start, int numWords, string[] words)
        {
            if (index >= arr.Length)
            {
                subsetArr[n] = "(";
                for (int i = 0; i < arr.Length; i++)
                {
                    subsetArr[n] += words[arr[i]];
                    if (i != arr.Length - 1)
                        subsetArr[n] += " ";
                }
                subsetArr[n] += ")";
                n++;
            }
            else
            {
                for (int i = start; i < numWords; i++)
                {
                    arr[index] = i;
                    Find(arr, index + 1, i + 1, numWords, words);

                }
            }
        }
    }

    /*static string[] wordsArr;

        public static string Find(int[] arr, int index, int start, int end)
        {
            StringBuilder sb = new StringBuilder();
            do
            {
                if (index >= arr.Length)
                {
                    sb.Append("(");
                    for (int j = 0; j < arr.Length; j++)
                    {
                        sb.Append(arr[j]);
                        if (j != arr.Length - 1) sb.Append(" ");
                    }
                    sb.Append("), ");
                }
                else
                {
                    for (int i = start; i < end; i++)
                    {
                        arr[index] = i;
                        Find(arr, index + 1, i + 1, end);
                    }
                }
            }
            while (index < end);
            return Convert.ToString(sb);
        }
    }*/
}
