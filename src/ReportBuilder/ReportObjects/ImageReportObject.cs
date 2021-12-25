using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public class ImageReportObject : ReportObject
    {
        public ImageReportObject( string path, int x, int y, int width, int height )
        {
            Path = path;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public override ReportObjectTypes Type => ReportObjectTypes.Img;
        public string Path { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

    }
}
