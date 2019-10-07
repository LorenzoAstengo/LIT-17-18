using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Exercise10
{
    public class ExtractEmails
    {
        public static string Extract(string fileName)
        {
            string text=File.ReadAllText(fileName);
            StringBuilder sb = new StringBuilder();
            foreach (var item in Regex.Matches(text, @"([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})"))
            {
                sb.Append(Convert.ToString(item));
                sb.Append(" ");
            }
            return Convert.ToString(sb);
        }
    }
}
