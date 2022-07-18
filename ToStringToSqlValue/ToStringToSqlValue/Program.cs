using System;
using System.Collections.Generic;
using System.Linq;

namespace ToStringToSqlValue
{
    class Program
    {
        static void Main(string[] args)
        {
            CastString castString = new CastString();
            Builder builder = new Builder();
            List<string> textLines = System.IO.File.ReadAllLines(@"I:\Nueva carpeta (2)\UNED\PROGRAMACION AVANZADA EN WEB\text.txt").ToList();
            
            textLines = castString.DeleteNumbersAndSpaces(textLines);
            string result = builder.BuildSqlValues(textLines);
            Console.WriteLine(result);
        }
    }
}
