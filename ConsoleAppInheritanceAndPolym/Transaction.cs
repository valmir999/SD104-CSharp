using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritanceAndPolym
{
    class Transaction
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public bool isSuccessful { get; set; }
        public DateTime TimeStamp { get; set; }

        public string Detail { get; set; }
    }
}
