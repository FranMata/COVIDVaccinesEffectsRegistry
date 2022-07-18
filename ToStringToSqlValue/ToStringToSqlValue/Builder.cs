using System;
using System.Collections.Generic;
using System.Text;

namespace ToStringToSqlValue
{
    public class Builder
    {
        public string BuildSqlValues(List<string> textArray)
        {
            string result = "";
            textArray.ForEach(e => result += string.Format("('{0}'),\n", e));
            return result;
        }
    }
}
