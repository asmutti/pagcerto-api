using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models.ServiceModel
{
    interface ITransactionService
    {
        Task<Transaction> AddTransaction(Transaction transaction);

        Task<List<Transaction>> TransactionsAvailableForPrePayment();

    }
}
