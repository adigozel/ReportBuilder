using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public class FieldReportObject : TextReportObject
    {
        public FieldReportObject( int length, ReportFont font, string key ) : base( length, font )
        {
            Key = key;
        }

        public override ReportObjectTypes Type => ReportObjectTypes.Filed;
        public string Key { get; set; }

    }
}
