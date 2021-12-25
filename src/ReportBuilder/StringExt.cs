using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public static class StringExt
    {
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value) || maxLength <= 0) 
                return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}
