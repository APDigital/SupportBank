using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportBank
{
    class Account : DataRecords
    {
        public Account(DataRecords data) : base()
        {
            DateTime date = Date;
            string narrative = Narrative;
            name = GetName(From, To);
            double amount = Amount;
        }

        get transaction
        public string GetTransaction(DataRecords data)
        {
            var transaction = new Transaction(data);
            return string.Format("{0}: owes {1} and is owed {2}", data.name, transaction.GetTotalTheyOwe(data.From), transaction.GetValueOwed(data.From));
        }

    }
}
