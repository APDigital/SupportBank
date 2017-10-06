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
                IEnumerable<DataRecords> records = reader.GetRecords<DataRecords>();
                try
                {
                    foreach (var item in records)
                    {
                        Transaction transaction = new Transaction(item);
                        Account account = new Account(item);
                        Console.WriteLine(item);
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error: {0}", e);
                }

                //Account account = new Account();


                //string printTransaction = account.GetTransaction();

                //string listAccount = getListAccount();

                //Console.WriteLine(listAccount);

                Console.ReadLine();


                //string getListAccount()
                //{
                //    if (records != null)
                //    {
                //        List<string> data = new List<string>();
                //        foreach (var record in records)
                //        {
                //            data.Add(string.Format("Transaction:{0} | Date:{1} | Narrative:{2}", printTransaction, dataRecord.Date, dataRecord.Narrative));

                //        }
                //        return data.ToString();
                //    }
                //    return "no records available";
                //}

            }

        }
    }
}
