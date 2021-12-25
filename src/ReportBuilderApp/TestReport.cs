using System;
using System.Collections.Generic;
using System.Drawing;
using ReportBuilder;

namespace ReportBuilderApp
{
    public class TestReport:Report
    {
        public TestReport( )
        {
            var fs = new ReportFont("Consolas", 2.2f, FontStyle.Regular, GraphicsUnit.Millimeter );
            var fb = new ReportFont("Consolas", 2.3f, FontStyle.Bold, GraphicsUnit.Millimeter );
            var fe = new ReportFont("Consolas", 3f, FontStyle.Bold, GraphicsUnit.Millimeter );
            
            TitleBand = new List<ReportItem>( ) {
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(2,fs,""),
                        //new ImageReportObject("logo.png",0,0,50,50),
                        new FieldReportObject(0,fs,"#checkHeaderTemplate"),
                    },
                    Height = 55
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(8,fs,""),
                        new LabelReportObject(0,fb,"SALE CHECK:"),
                        new FieldReportObject(0,fs,"#number"),
                    },
                    Height = 15
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(8,fs,""),
                        new LabelReportObject(0,fs,"DATE:"),
                        new FieldReportObject(0,fs,"#date")
                    },
                    Height = 15,
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                    },
                    Height = 10
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                         new LabelReportObject(14,fb,"Product"),
                         new LabelReportObject(6,fb,"Quantity"),
                         new LabelReportObject(9,fb,"Price"),
                         new LabelReportObject(0,fb,"Sum"),
                    },
                    Height = 15,
                }
            };

            DataBand = new ReportItem( ) {
                Objects = new List<ReportObject>( ) {
                        new DataFieldReportObject(18,fs,"Name"),
                        new DataFieldReportObject(4,fs,"Quantity"),
                        new DataFieldReportObject(6,fs,"Price"),
                        new LabelReportObject(1,fs,"="),
                        new DataFieldReportObject(0,fb,"Sum"),
                    },
                Height = 15,
            };

            FooterBand = new List<ReportItem>() {

                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                    },
                    Height = 10
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(10,fs,""),
                        new LabelReportObject(0,fs,"First Sum:"),
                        new FieldReportObject(0,fs,"#rawsum"),
                    },
                    Height = 15
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(10,fs,""),
                        new LabelReportObject(0,fs,"Discount:"),
                        new FieldReportObject(0,fs,"#discount"),
                        new LabelReportObject(0,fs,"%"),
                    },
                    Height = 15
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(10,fs,""),
                        new LabelReportObject(0,fe,"Result Sum:"),
                        new FieldReportObject(0,fe,"#sum"),
                    },
                    Height = 17
                },
                new ReportItem()
                {
                    Objects = new List<ReportObject>()
                    {
                        new LabelReportObject(0,fb,""),
                    },
                    Height = 5
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        //new LabelReportObject(10,fs,""),
                        new LabelReportObject(0,fs,"Cahs:"),
                        new FieldReportObject(0,fs,"#cash"),
                    },
                    Height = 15
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(0,fs,"Bank:"),
                        new FieldReportObject(0,fs,"#bank"),
                    },
                    Height = 15
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(0,fs,"Bonus:"),
                        new FieldReportObject(0,fs,"#usebonus"),
                    },
                    Height = 15
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(0,fs,"Credit:"),
                        new FieldReportObject(0,fs,"#credit"),
                    },
                    Height = 15
                },
                new ReportItem()
                {
                    Objects = new List<ReportObject>(),
                    Height = 10
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(0,fs,"Customer:"),
                        new FieldReportObject(0,fs,"#customer"),
                    },
                    Height = 15
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(0,fs,"Customer's bonus:"),
                        new FieldReportObject(0,fs,"#customerbonus"),
                    },
                    Height = 15
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(0,fs,"Customer's debit:"),
                        new FieldReportObject(0,fs,"#customerdebit"),
                    },
                    Height = 15
                },

                new ReportItem()
                {
                    Objects = new List<ReportObject>(),
                    Height = 10
                },

                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(0,fs,"Purchase:"),
                        new FieldReportObject(0,fs,"#purchase"),
                    },
                    Height = 17
                },
                new ReportItem( ) {
                    Objects = new List<ReportObject>( ) {
                        new LabelReportObject(0,fs,"Money back:"),
                        new FieldReportObject(0,fs,"#moneyback"),
                    },
                    Height = 17
                },
                new ReportItem()
                {
                    Objects = new List<ReportObject>()
                    {
                        new LabelReportObject(0,fb,""),
                    },
                    Height = 10
                },

                new ReportItem()
                {
                    Objects = new List<ReportObject>()
                    {
                        //new BarcodeReportObject("#number",BarcodeLib.TYPE.CODE128,5,0,180,30)
                    },
                    Height = 35
                },                
                new ReportItem()
                {
                    Objects = new List<ReportObject>()
                    {
                        new LabelReportObject(14,fs,""),
                        new FieldReportObject(0,fs,"#number")
                    },
                    Height = 20
                },
                new ReportItem()
                {
                    Objects = new List<ReportObject>()
                    {
                        new LabelReportObject(0,fs,""),
                        new FieldReportObject(0,fs,"#checkFooterTemplate"),
                    },
                    Height = 15
                },
            };
        }
    }
}
