using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilder
{
    public class ReportDrawer<T>
    {
        private readonly Report _report;
        private readonly ReportData<T> _data;

        public ReportDrawer( Report report, ReportData<T> data )
        {
            _report = report;
            _data = data;
        }

        private void DrawItem( Graphics graphics, ReportItem item,float y,object dataItem = null)
        {
            float x = 0;
            foreach(var obj in item.Objects) {

                if(obj is LabelReportObject) {
                    var textObj = obj as LabelReportObject;
                    var text = textObj.Text.Truncate(textObj.Length);
                    graphics.DrawString( text, textObj.Font.GetFont( ), Brushes.Black, new PointF( x, y ) );
                    x += graphics.MeasureString( text.PadRight( textObj.Length, '#'), textObj.Font.GetFont( ) ).Width;
                }
                else if(obj is FieldReportObject) {
                    var fieldObj = obj as FieldReportObject;
                    var text = _data.GetParmsValue(fieldObj.Key ).Truncate(fieldObj.Length);
                    graphics.DrawString( text, fieldObj.Font.GetFont( ), Brushes.Black, new PointF( x, y ) );
                    x += graphics.MeasureString( text.PadRight( fieldObj.Length, '#' ), fieldObj.Font.GetFont( ) ).Width;
                }
                else if (obj is DataFieldReportObject) {
                    var dataFiledObj = obj as DataFieldReportObject;
                    var text = _data.GetDataValue( dataItem, dataFiledObj.Key ).Truncate(dataFiledObj.Length); ;
                    graphics.DrawString( text, dataFiledObj.Font.GetFont(), Brushes.Black, new PointF( x, y ) );
                    x += graphics.MeasureString( text.PadRight( dataFiledObj.Length,'#'), dataFiledObj.Font.GetFont( ) ).Width;
                }
                else if (obj is ImageReportObject) {
                    
                    var imgObj = obj as ImageReportObject;
                    
                    if (!File.Exists(imgObj.Path))
                        continue;

                    Image img = Image.FromFile( imgObj.Path );
                    graphics.DrawImage( img, new Rectangle( imgObj.X, (int)y + imgObj.Y, imgObj.Width, imgObj.Height ) );
                    img.Dispose( );
                    x += imgObj.X + imgObj.Width;
                }
                else if (obj is BarcodeReportObject)
                {
                    var barcodeObj = obj as BarcodeReportObject;
                    var text = _data.GetParmsValue(barcodeObj.Key);
                    Image img = barcodeObj.GenBarCodeImage(text);
                    graphics.DrawImage(img, new Rectangle(barcodeObj.X, (int)y + barcodeObj.Y, barcodeObj.Width, barcodeObj.Height));
                    img.Dispose();
                    x += barcodeObj.X + barcodeObj.Width;
                }
            }
        }
        public void Draw( Graphics graphics )
        {
            float y = 3;

            foreach (var item in _report.TitleBand)
            {
                DrawItem(graphics, item, y);
                y += item.Height;
            }

            foreach (var dataItem in _data.Data)
            {
                DrawItem(graphics, _report.DataBand, y, dataItem);
                y += _report.DataBand.Height;
            }

            foreach (var item in _report.FooterBand)
            {
                DrawItem(graphics, item, y);
                y += item.Height;
            }


        }
    }
}
