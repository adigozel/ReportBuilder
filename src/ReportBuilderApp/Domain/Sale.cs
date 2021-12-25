using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportBuilderApp.Domain
{
    internal class Sale
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Moment { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public bool HasCustomer => !string.IsNullOrEmpty(CustomerId);
        public decimal Discount { get; set; }
        public decimal Amount { get; set; }
        public decimal UseBonus { get; set; }
        public decimal Bank { get; set; }
        public decimal Credit { get; set; }
        public decimal RawSum { get; set; }
        public decimal Purchase { get; set; }
        public decimal MoneyBack { get; set; }
        public List<SaleItem> Items { get; set; }
        public decimal Sum => Amount + UseBonus + Bank + Credit;
        public decimal GetUseBonusPercent()
        {
            if ((Sum) == 0)
                return 0;

            var percent = UseBonus * 100 / (Sum);

            return percent;
        }

        
    }
}
