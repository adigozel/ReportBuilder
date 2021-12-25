using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public class DataFieldReportObject : TextReportObject
    {
        public DataFieldReportObject( )
        {

        }
        public DataFieldReportObject( int length, ReportFont font, string key ) : base( length, font )
        {
            Key = key;
        }

        public override ReportObjectTypes Type => ReportObjectTypes.DataField;
        public string Key { get; set; }

    }
}
