using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Transaction
    {
        public const int MaximumInstallment = 12;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool cardProcessed { get; set; }
        public Decimal TotalValue { get; set; }
        public Decimal PaymentValue { get; set; }
        public int Installments { get; set; }
        public String FourDigitsCard { get; set; }








    }
}
