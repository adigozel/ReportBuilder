using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderApp
{
    internal class Utils
    {
        public static string PriceToString(decimal price)
        {
            return Math.Round(price, 2, MidpointRounding.AwayFromZero).ToString();
        }
    }
}
