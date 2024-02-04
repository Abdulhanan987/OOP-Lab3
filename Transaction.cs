using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class Transaction
    {

        public int TransactionID;
        public string ProductName;
        public float Amount;
        public int Date;
        public string Time;
        public Transaction()
        {

        }
        public Transaction(Transaction transaction)
        {
            TransactionID = transaction.TransactionID;
            ProductName = transaction.ProductName;
            Amount = transaction.Amount;
            Date = transaction.Date;
            Time = transaction.Time;
        }
    }
}
