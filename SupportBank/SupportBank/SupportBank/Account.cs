using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportBank
{
    class Account
    {
        private string Name { get; set; }
        private List<Transaction> Transactions { get; set; }
        public Account(string name, List<Transaction> transactions)
        {
            Name = name;
            Transactions = transactions;
        }
        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public double GetTotal()
        {
            double totalOwed = 0;
            double valueToPay = 0;

            foreach (var transaction in Transactions)
            {
                if (transaction.From == Name)
                {
                    valueToPay = valueToPay + transaction.Amount;
                }
                else
                {
                    totalOwed = totalOwed + transaction.Amount;
                }
            }

            return totalOwed - valueToPay;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Balance{1}", Name, GetTotal());
        }


    }
}
