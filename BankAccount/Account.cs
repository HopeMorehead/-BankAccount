using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccount
{
    enum accountTypes { Checking_Account = 1, Savings_Account = 2, Reserved_Account = 3 }

    class Account

   

    {
        public decimal MinimumBalance;
        public decimal Withdrawal;
        public decimal Deposit;
        public decimal Interest;
        public string Name;
        public int AccountNumber;
        public decimal CurrentBalance;
        
        

        public Account(decimal minimumBalance_, decimal withdrawal_, decimal deposit_, decimal interest_, string name_,  int accountNumber_)
        {
            this.Withdrawal = withdrawal_;
            this.Deposit = deposit_;
            this.Interest = interest_;
            this.Name = name_;
            this.MinimumBalance = minimumBalance_;
            this.AccountNumber = accountNumber_;
        }
        public Account()
        {
           // this.MinimumBalance = 100.00M;

        }

        public decimal withdrawal_
        {
            get
            {
                return this.Withdrawal;

            }
            set
            {
                this.Withdrawal = value;
            }
        }


        public decimal Deposit_
        {
            get
            {
                return this.Deposit;
            }
            set
            {
                this.Deposit = value;
            }
        }

        public string name__
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;

            }
        }

        public virtual void Getinformatiion()
        {

            decimal sunday = 60.00M;
            decimal monday = 60.00M;
            decimal tuesday = 60.00M;
            decimal wednesday = 60.00M;
            decimal thursday = 60.00M;
            decimal friday = 60.00M;
            decimal saturday = 60.00M;
            decimal workWeek = sunday + monday + tuesday + wednesday + thursday + friday + saturday;
            decimal biWeeklys = 2 * workWeek;
            decimal minimumBalance = 100.00M;

            decimal depositFunds = decimal.Parse(Console.ReadLine());
            decimal currentPositiveBalance = minimumBalance + depositFunds;
            // Console.WriteLine(minimumBalance);
         //   Console.WriteLine(currentPositiveBalance);

            int i = 0;
            while (i <= 4)
            {
                i++;
               
               //  i= i % 10;
               
                currentPositiveBalance += 840.00M;
                Console.WriteLine(currentPositiveBalance);
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                
                while (i != 2620.00)
                {
                    Console.WriteLine("Direct Deposit Monday - Friday");
                    break;    
                }
            }
        }
        public virtual void AcountInformation()
        {
            Console.WriteLine("Choose an account option 1. 2. or 3.");
            Console.WriteLine("");
            foreach (accountTypes types in Enum.GetValues(typeof(accountTypes)))
                Console.WriteLine(types);
            string listOptions = Console.ReadLine();
            accountTypes values;
            if (Enum.TryParse<accountTypes>(listOptions, true, out values))
                switch (values)
                {
                    case accountTypes.Checking_Account:
                        Console.WriteLine("Current Account balance:");
                        Console.WriteLine(940.00M);


                        decimal Y;
                        Console.WriteLine("Transfer Funds? Y/N ");

                        string depositFunds1 = (Console.ReadLine());
                        Console.WriteLine("Deposit amount");
                        Getinformatiion();

                        //  decimal depositFunds =decimal.Parse(Console.ReadLine());
                        decimal minimumBalance = 100.00M;
                        decimal currentPositiveBalance = minimumBalance + 840.00M;
                        decimal depositFunds = decimal.Parse(Console.ReadLine());

                        decimal newAmount = depositFunds + currentPositiveBalance;

                      

                        if (depositFunds1 == "Y")
                        {
                            Console.WriteLine(newAmount);
                            Console.WriteLine(" options 2.savings or 3. Reserve?");
                            while (depositFunds1 == "N")
                            {
                                Console.WriteLine(minimumBalance);
                                
                            }

                        }
                        
                        break;
                        case accountTypes.Savings_Account:
                           Console.WriteLine("Current savings account balance:40000");
                      

                        break;
                        case accountTypes.Reserved_Account:
                            Console.WriteLine("Current reserved Account balance:60000");
                        break;
                }
        }
        
        public virtual void Credits(DateTime Withdrawal)

        {
            DateTime value = new DateTime(2017, 3, 13);
            Console.WriteLine(value);
            Console.WriteLine("A credit has been made");

         }
    }
}

