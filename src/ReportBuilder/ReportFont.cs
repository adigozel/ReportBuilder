using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public class ReportFont
    {

        public ReportFont( string familyName, float size, FontStyle style, GraphicsUnit unit )
        {
            FamilyName = familyName;
            Size = size;
            Style = style;
            Unit = unit;
        }

        public string FamilyName { get; set; }
        public float Size { get; set; }
        public FontStyle Style { get; set; }
        public GraphicsUnit Unit { get; set; }

        public Font GetFont( )
        {
            return new Font( FamilyName, Size, Style, Unit );
        }
    }
}
