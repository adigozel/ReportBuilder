using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public abstract class TextReportObject : ReportObject
    {
        public TextReportObject( )
        {

        }
        protected TextReportObject( int length, ReportFont font )
        {
            Length = length;
            Font = font;
        }

        public int Length { get; set; }
        public ReportFont Font { get; set; }

    }

}
