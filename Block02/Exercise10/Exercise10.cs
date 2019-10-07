using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Encryption
    {
        public static char[] EncryptText(string a, string code)
        {
            char[] cryptedText = new char[a.Length];
            int c = 0;
            for (int i = 0; i < a.Length; i++)
            {
                cryptedText[i] = Convert.ToChar((a[i])^(code[c]));
                c++;
                if (c == code.Length)
                {
                    c = 0;
                }
            }
            return cryptedText;
        }
    }
}
