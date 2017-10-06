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

        public override string ToString()
        {
            return "Person From: " + From + " Person To: " + To + " Amount Owed: " + Amount + " | Date: " + Date.Date.ToString("d") + " Narrative: " + Narrative ;
        }
    }
}
