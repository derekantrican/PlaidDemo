using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidDemo
{
    public class Transaction
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string AccountId { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public string FormattedAmount
        {
            get
            {
                if (Amount < 0)
                    return "-$" + Math.Abs(Amount);
                else
                    return "$" + Amount;
            }
        }

        public override string ToString()
        {
            return Date.ToShortDateString() + " " + Name + " " + FormattedAmount;
        }
    }
}
