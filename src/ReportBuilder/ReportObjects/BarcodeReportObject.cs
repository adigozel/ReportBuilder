using System;
using System.Drawing;
using BarcodeLib;

namespace ReportBuilder
{
    public class BarcodeReportObject : ReportObject
    {
        public override ReportObjectTypes Type => ReportObjectTypes.Barcode;

        public BarcodeReportObject( string key, TYPE tYPE, int x, int y, int width, int height )
        {
            Key = key;
            TYPE = tYPE;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public string Key { get; set; }
        public TYPE TYPE { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height {get;set;}


        public Image GenBarCodeImage( string text)
        {
            Barcode barcodLib = new Barcode( );
            //int imageWidth = 180;  // barcode image width
            //int imageHeight = 30; //barcode image height
            Color foreColor = Color.Black; // Color to print barcode
            Color backColor = Color.Transparent; //background color
            Image barcodeImage = barcodLib.Encode( TYPE, text, foreColor, backColor, Width, Height );
            return barcodeImage;
        }
    }
}
