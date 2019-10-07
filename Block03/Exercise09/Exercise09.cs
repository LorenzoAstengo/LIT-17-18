using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public class ModifyCasingOfLetters
    {
        public static string ToUppercase(string text)
        {
            string openingTag = "<upcase>";
            string closingTag = "</upcase>";
            int openingIndex = text.IndexOf(openingTag);
            int closingIndex = text.IndexOf(closingTag);
            while (openingIndex != -1)
            {
                if (closingIndex != -1)
                {
                    int lenght = (closingIndex + closingTag.Length) - openingIndex;
                    string selected = text.Substring(openingIndex, lenght);
                    string upper = selected.ToUpper();
                    upper = upper.Replace((openingTag.ToUpper()), string.Empty);
                    upper = upper.Replace((closingTag.ToUpper()), string.Empty);
                    text = text.Replace(selected, upper);
                }
                openingIndex = text.IndexOf(openingTag);
                closingIndex = text.IndexOf(closingTag);
            }
            return text;
        }
            
    }
}

