using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaction transaction = new Transaction();
            transaction.TransactionID = 123;
            transaction.ProductName = "ABC";
            transaction.Amount = 100;
            transaction.Date = 12;
            transaction.Time = "10:30";
            Transaction transaction1 = new Transaction(transaction);
            transaction1.Date = 10;
            transaction1.TransactionID = 157;
            transaction1.Amount = 120;
            transaction.Date = 12;
            Console.WriteLine(transaction.Date);
            Console.WriteLine(transaction1.Date);
            Console.ReadKey();
        }
    }
}
