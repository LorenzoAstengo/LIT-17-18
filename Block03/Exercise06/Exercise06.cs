using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise06
{
    public class FileParseException : Exception
    {
        private string fileName;
        private long lineNumber;
        public FileParseException() { }
        public string FileName { get { return fileName; } private set { fileName = value; } }
        public long LineNumber { get { return lineNumber; } private set { lineNumber = value; } }

        public FileParseException(string fileName, long lineNumber)
        {
            FileName = fileName;
            LineNumber = lineNumber;
        }
    }

    public class ReadIntegerFromAFile
    {
        public static string ReadFile(string fileName)
        {
            int line = 0;
            string text;
            StreamReader reader = new StreamReader(fileName);
            StringBuilder sb = new StringBuilder();
            while ((text = reader.ReadLine()) != null)
            {
                    string res = Regex.Replace(text, "[^0-9]+", string.Empty);
                    if (res.Length == 0)
                    {
                        throw new FileParseException(fileName,line);
                    }
                    else
                    {
                        sb.Append(res);
                        sb.Append(" ");
                        line++;
                    }
            }
            return Convert.ToString(sb);
        }
    }
}
