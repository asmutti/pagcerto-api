using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Prepayment
    {

        public int id { get; set; }
        public DateTime requestDate { get; set; }
        public DateTime requestAnalisys { get; set; }
        public Boolean status { get; set; }
        public Decimal finalValue { get; set; }
        public Decimal finalPayment { get; set; }
        public List<Transaction> transactions { get; set; }
    }
}
