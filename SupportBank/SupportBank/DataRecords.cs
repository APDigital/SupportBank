using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportBank
{
    class DataRecords
    {
        public string name;
        DateTime date;
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Narrative { get; set; }
        public double Amount { get; set; }

        public DataRecords()
        {

        }
        public override string ToString()
        {
            date = Date;
            DateTime dateOnly = date.Date;
            return "Record: " + dateOnly.ToString("d") + " " + From + " " + To + " " + Narrative + " " + Amount;
        }

        //get persons name if from and to are the same name 
        public string GetName(string from, string to)
        {
            if (from == to)
            {
                name = from;
            }
            return name;
        }

    }
}
