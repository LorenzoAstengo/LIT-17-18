using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    public class RepeatedLetters
    {
        public static string EliminateRepeatedLetters(string repeatedString)
        {
            int k = 0;
            StringBuilder res = new StringBuilder();
            res.Append(repeatedString[0]);
            for(int i = 1; i < repeatedString.Length; i++)
            {
                if (res[k] != repeatedString[i])
                {
                    res.Append(repeatedString[i]);
                    k++;
                }
            }
            return res.ToString();
        }
    }
}
