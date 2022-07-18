using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ToStringToSqlValue
{
    public class CastString
    {
        public List<string> GetStringArray(string text) => text.Split("\\n").ToList();

        public List<string> DeleteNumbersAndSpaces(List<string> textArray)
        {
            List<string> cleanText = new List<string>();
            textArray.ForEach(e => cleanText.Add(Regex.Replace(e, @"(\d*.\s)", "")));
            return cleanText;
        }
    }
}
