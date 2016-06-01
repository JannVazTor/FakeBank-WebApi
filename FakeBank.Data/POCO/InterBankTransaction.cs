using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeBank.Data.POCO
{
    public class InterBankTransaction
    {
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public int SecurityCode { get; set; }
        public Guid Token { get; set; }
        public double Amount { get; set; }
    }
}
