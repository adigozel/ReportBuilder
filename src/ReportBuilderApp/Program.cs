using ReportBuilder;
using ReportBuilderApp.Domain;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;

namespace ReportBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var sale = new Sale()
            {
                Name = Guid.NewGuid().ToString(),
                Moment = DateTime.Now,
                Amount = 100,
                RawSum = 100,
                Purchase = 110,
                MoneyBack = 10,
                Items = new List<SaleItem>()
                {
                    new SaleItem()
                    {
                        Name = "X1 Product",
                        Quantity = 10,
                        Price  = 2,
                    },
                    new SaleItem()
                    {
                        Name = "X2 Product",
                        Quantity = 10,
                        Price  = 3,
                    },
                    new SaleItem()
                    {
                        Name = "X2 Product",
                        Quantity = 10,
                        Price  = 5,
                    }
                }
            };
            CheckPrint(sale);
        }

        public static void CheckPrint(Sale sale)
        {
            try
            {
                PrintDocument Pd = new PrintDocument();
                string PrinterName = PrinterSettings.InstalledPrinters[0];
                PrinterSettings Ps = new PrinterSettings();
                Ps.PrinterName = PrinterName;
                Pd.PrinterSettings = Ps;
                Pd.PrintPage += (sender, e) => {
                    PdPrintPage(sender, e, sale);
                };
                Pd.Print();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void PdPrintPage(object sender, PrintPageEventArgs e, Sale sale)
        {
            try
            {
                var customer = sale.Customer;
                var hasCust = customer != null;
                var data = new ReportData<SaleItem>()
                {
                    Parms = new Dictionary<string, string>() {
                    { "#date",sale.Moment.ToString() },
                    { "#number",sale.Name.ToString() },
                    { "#rawsum",Utils.PriceToString(sale.RawSum).ToString()},
                    { "#discount",Utils.PriceToString(sale.Discount).ToString()},
                    { "#sum",Utils.PriceToString(sale.Sum).ToString()},
                    { "#cash",Utils.PriceToString(sale.Amount).ToString()},
                    { "#bank",Utils.PriceToString(sale.Bank).ToString()},
                    { "#usebonus",Utils.PriceToString(sale.UseBonus).ToString()},
                    { "#credit",Utils.PriceToString(sale.Credit).ToString()},
                    { "#customer",hasCust? customer.Name:"_"},
                    { "#customerbonus",hasCust?Utils.PriceToString(customer.Bonus).ToString():"0"},
                    { "#customerdebit",hasCust && customer.Debt.HasValue?Utils.PriceToString(customer.Debt.Value).ToString():"0"},
                    { "#purchase",Utils.PriceToString(sale.Purchase).ToString()},
                    { "#moneyback",Utils.PriceToString(sale.MoneyBack).ToString()},
                    { "#checkHeaderTemplate","You are welcome"},
                    { "#checkFooterTemplate","You are welcome"}

                },
                    Data = sale.Items.ToList()
                };

                Report rep = new TestReport();

                var drawer = new ReportDrawer<SaleItem>(rep, data);

                drawer.Draw(e.Graphics);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
    }
}
