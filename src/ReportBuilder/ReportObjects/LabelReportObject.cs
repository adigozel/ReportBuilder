using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public class LabelReportObject : TextReportObject
    {
        public LabelReportObject( int length, ReportFont font, string text ) : base( length, font )
        {
            Text = text;
        }

        public override ReportObjectTypes Type => ReportObjectTypes.Label;
        public string Text { get; set; }
        //public override string GetValue( ReportDataSource dataSource )
        //{
        //    if(Text.Length >= Length)
        //        return Text;
        //    else
        //        return Text.PadLeft( Length,' ' );
        //}
    }
}
