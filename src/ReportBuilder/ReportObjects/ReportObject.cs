using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public abstract class ReportObject
    {
        public abstract ReportObjectTypes Type { get; }
    }
}
