using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidDemo
{
    public class Institution
    {
        public Institution()
        {
            Credentials = new Credentials();
            Accounts = new List<Account>();
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public Credentials Credentials { get; set; }
        public List<Account> Accounts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
