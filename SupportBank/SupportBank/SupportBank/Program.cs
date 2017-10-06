using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace SupportBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var sr = new StreamReader("SupportBankDetails.csv"))
            {
                var reader = new CsvReader(sr);
                IEnumerable<Transaction> transactions = reader.GetRecords<Transaction>().ToList();
                Dictionary<string, Account> accounts = new Dictionary<string, Account>();

                try
                {
                    foreach (var transaction in transactions)
                    {
                        if (!accounts.ContainsKey(transaction.From))
                        {
                            accounts.Add(transaction.From, new Account(transaction.From, new List<Transaction>()));
                        }
                        if (!accounts.ContainsKey(transaction.To))
                        {
                            accounts.Add(transaction.To, new Account(transaction.To, new List<Transaction>()));
                        }
                        accounts[transaction.From].AddTransaction(transaction);
                        accounts[transaction.To].AddTransaction(transaction);
                        //Console.WriteLine(transaction.ToString());
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: {0}", e);
                }
                //string listAccount = getListAccount();

                //Console.WriteLine(listAccount);
                Console.WriteLine("do you want to view a list of All or Transactions? please enter all/transaction ");
                string userInput = Console.ReadLine();
                if (userInput == "all")
                {
                    foreach (var account in accounts.Values)
                    {
                        Console.WriteLine(account.ToString());
                    }
                }
                else
                {
                    foreach (var transaction in transactions)
                    {
                        Console.WriteLine(transaction.ToString());
                    }
                }

                Console.ReadLine();


                //string getListAccount()
                //{
                //    if (records != null)
                //    {
                //        List<string> data = new List<string>();
                //        foreach (var record in records)
                //        {
                //            Account account = new Account(record);

                //            data.Add(string.Format("Transaction:{0} | Date:{1} | Narrative:{2}", printTransaction, record.Date, record.Narrative));

                //        }
                //        return data.ToString();
                //    }
                //    return "no records available";
                //}

            }

        }
    }
}
