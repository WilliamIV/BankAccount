using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Account
    {
        
        //fields
        public string acctName = "Hilary Clinton";
        public string acctNumber = "2017";
        public int userWithdraw;
        public int userDeposit;


        //properties

        public string AcctName
        { get;
            set; }

        public string AcctNumber
        { get;
            set; }



        //methods

        public void CustomerDisplay()
        {
            Console.WriteLine("Here is your account information");
            Console.WriteLine("Account Holder: " + this.acctName);
            Console.WriteLine("Account Number: " + this.acctNumber);
        }


        
        public virtual void Withdraw(Account currentAccount)
        {
            Console.WriteLine("Please enter the amount you'd like to withdraw.");
            this.userWithdraw = int.Parse(Console.ReadLine());
            Console.WriteLine("You requested " + "$" + this.userWithdraw);
        }


        
        public virtual void Deposit(Account currentAccount)
        {
            Console.WriteLine("Please enter the amount you'd like to depsit.");
            this.userDeposit = int.Parse(Console.ReadLine());
            Console.WriteLine("You requested " + "$" + this.userDeposit);
         } 



    }
}