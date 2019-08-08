using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.ServiceModel
{
    interface IPrePaymentService
    {
        Task<Prepayment> InitPrePaymentRequest();

        Task<Prepayment> addTransactionPrePayment(int transactionId);

        Task<Prepayment> SubmitPrepaymentRequest(int id);
        
        Task<Prepayment> SetTransactionStatus(bool status);

        Task<Prepayment> CheckPrePaymentStatus(int id);

        //TODO: consulta de prepayments por período.


    }
}
