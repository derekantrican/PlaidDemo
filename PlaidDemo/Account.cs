using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidDemo
{
    public class Account
    {
        public Account()
        {
            RecentTransactions = new List<Transaction>();
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public Enums.AccountType Type { get; set; }
        public double AvailableBalance { get; set; }
        public List<Transaction> RecentTransactions { get; set; }
        public string FormattedBalance
        {
            get
            {
                if (AvailableBalance < 0)
                    return "-$" + Math.Abs(AvailableBalance);
                else
                    return "$" + AvailableBalance;
            }
        }

        public override string ToString()
        {
            return Name + " (" + FormattedBalance + ")";
        }
    }
}
