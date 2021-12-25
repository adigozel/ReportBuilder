using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{

    public class Report
    {
        public Report( )
        {
        }
        public List<ReportItem> TitleBand { get; set; }
        public ReportItem DataBand { get; set; }
        public List<ReportItem> FooterBand { get; set; }

    }
    
    public class ReportItem
    {
        public List<ReportObject> Objects { get; set; }
        public float Height { get; set; }
    }
    
    
}
