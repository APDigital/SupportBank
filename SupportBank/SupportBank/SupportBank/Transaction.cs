using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportBank
{
    class Transaction
    {
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Narrative { get; set; }
        public double Amount { get; set; }

        public Transaction()
        {
            
        }
        public double GetValueOwed()
        {
            if (To != null)
            {
                From.Replace(From, To);
                return Amount;

            }
            else
            {
                return 0;
            }

        }

        public override string ToString()
        {
            return "Record: " + Date.Date.ToString("d") + " " + From + " " + To + " " + Narrative + " " + Amount;
        }

        //public string GetTransaction()
        //{
        //    return string.Format("{0}: owes {1} and is owed {2}", data.From, data.Amount, GetValueOwed());
        //}
        //public override string ToString()
        //{
        //    return string.Format("Transaction:{0} | Date:{1} | Narrative:{2}", GetTransaction(data), Date, Narrative);
        //}

        public static implicit operator Version(Transaction v)
        {
            throw new NotImplementedException();
        }
        //get total they owe (person from:person to | Amount)
        //get total owed (if person from has anyone who owes them money print amount
    }
}
