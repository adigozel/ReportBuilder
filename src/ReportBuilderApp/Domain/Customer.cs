using System;

namespace ReportBuilderApp.Domain
{
    internal class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public decimal Discount { get; set; }
        public decimal Bonus { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Card { get; set; }
        public decimal? Debt { get; set; }
        public decimal Tax => Discount > 0 ? 0 : -1 * Discount;
        public decimal BonusRounded => Math.Round(Bonus, 2, MidpointRounding.AwayFromZero);
        public void DecreaseBonus(decimal bonus )
        {
            Bonus -= bonus;
        }

        public void IncreaseBonus( decimal bonus )
        {
            Bonus += bonus;
        }

        public void DecreaseDebit(decimal debit)
        {
            if (Debt == null)
                Debt = -debit;
            else
                Debt -= debit;
        }

        public void IncreaseDebit(decimal debit)
        {
            if (Debt == null)
                Debt = debit;
            else
                Debt += debit;
        }


        public bool IsEmpty( )
        {
            return string.IsNullOrEmpty( this.Id );
        }
        public static Customer Empty( )
        {
            return new Customer( ) {

            };
        }
    }
}
