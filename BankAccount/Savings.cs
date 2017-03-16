using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings: Account
    {


        public virtual void Credits(DateTime Withdrawal)
        {
            Console.WriteLine("A transaction has been made.");
        }
















    }
}
