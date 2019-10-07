using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    public class SearchForASubstring
    {
        public static int HowManyTimesRepeated(string text, string substring)
        {
            string textLowered = text.ToLower();
            string substringLowered = substring.ToLower();
            int index = textLowered.IndexOf(substringLowered);
            int k = 0;

            while (index != -1)
            {
                index = textLowered.IndexOf(substringLowered, index + 1);
                k++;
            }
            return k;
        }
    }
}
