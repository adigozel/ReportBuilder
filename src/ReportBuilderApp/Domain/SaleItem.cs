using System;

namespace ReportBuilderApp.Domain
{
    internal class SaleItem
    {
        public string ProductId { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Sum => Quantity * Price;
    }
}
