using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    class Checking : Account
    {
        public decimal Credit { get; internal set; }

        public void Account()
        {

        }

        public override void Getinformatiion()
        {
             base.Getinformatiion();
        }

        public override void Credits(DateTime Withdrawaltime)
        {

            DateTime value = new DateTime(2017, 3, 13);
            Console.WriteLine(value);
            Console.WriteLine(value == DateTime.Today);
            StreamWriter sw = new StreamWriter(@"Reciepts.txt");
            using (sw)
                if ((Withdrawaltime == value))
                {
                    sw.WriteLine("Transaction" + Withdrawaltime.ToString());
                    Console.WriteLine("A transaction was made.");
                }
                else
                {
                    Console.WriteLine();
                    using (sw)
                    Console.WriteLine("Pending transactions");
                    sw.Close();
           }
       }
   }    
}
