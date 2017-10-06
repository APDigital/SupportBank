using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportBank
{
    class Transaction : DataRecords
    {
        public string Name { get; set; }

        public Transaction(DataRecords data) : base()
        {
            name = GetName(From, To);
        }
        public double GetTotalTheyOwe(DataRecords data)
        {
            name = data.From;
            if (name != data.To)
            {
                return data.Amount;
            }
            else
            {
                return 0;
            }

        }
        public double GetValueOwed(DataRecords data)
        {
            name = data.From;
            if (name != data.To)
            {
                data.From.Replace(data.From, data.To);
                return data.Amount;

            }
            else
            {
                return 0;
            }

        }


        public static implicit operator Version(Transaction v)
        {
            throw new NotImplementedException();
        }
        //get total they owe (person from:person to | Amount)
        //get total owed (if person from has anyone who owes them money print amount
    }
}
