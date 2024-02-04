using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ATM
    {
        public float balance ;
        public List<string> history=new List<string>() ;
        public ATM(float Balance)
        {
            balance = Balance ;
        }
        public void deposit(float n1)
        {
            balance = balance + n1;
            
        }
        public void withDrawl(float n1)
        {
            if(n1 > balance)
            {
                Console.WriteLine("Not enough amount");
            }
            else
            {
                balance = balance - n1;
            }
            
        }
        public float check_amount()
        {
            return balance;
        }
        public void transaction_history(float n1,string type)
        {
            history.Add(type+" " +" " +n1);
        }
    }
}
