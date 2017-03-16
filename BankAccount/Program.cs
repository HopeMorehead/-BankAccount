using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    enum Workdays { sunday, monday, tuesday, wednesday, thursday, friday, saturday}
    class Program
    {
        // private static DateTime Withdrawaltime;

        static void Main(string[] args)
        {
            //string depositFunds1 = (Console.ReadLine());
            Console.WriteLine("Sam Smith account");
            Console.WriteLine("Account number:12345 67890 98765");
            Account management = new Account();
            //management.withdrawal_ = 00.00M;
            //management.Deposit_ = 00.00M;
            //management.Interest_ = 00.00M;
            Checking management0 = new Checking();
            //management0.withdrawal_ = 00.00M;
            //management0.Deposit_ = 00.00M;
            //management0.Interest_ = 00.00M;
            Savings management1 = new Savings();
            //management1.withdrawal_ = 00.00M;
            //management1.Deposit_ = 00.00M;
            //management1.Interest_ = 00.00M;

            Reserved management2 = new Reserved();
            //management2.withdrawal_ = 00.00M;
            //management2.Deposit_ = 00.00M;
            //management2.Interest_ = 00.00M;


            management.AcountInformation();

            DateTime value = new DateTime(2017, 3, 13);
            Console.WriteLine(value);
    }
  }
}
