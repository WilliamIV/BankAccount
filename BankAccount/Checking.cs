using Project3BankAccount;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Checking : Account


    {  //fields
        public double checkingBalance = 500;
        private string acctType = "checking";


        //properties

        private double CheckingBalance
        { get;
            set; }
        private string Type
        { get;
            set; }



       

        public Checking()
        {
            // do i need something here?  if errors...check here
        }






        //methods

        public void CurrentCheckingBalance()
        {
            Console.WriteLine("The balance in your checking account is " + CheckingBalance);
     
        }



        public override void Withdraw(Account checkingAccount)
        {
            base.Withdraw(checkingAccount);
            this.checkingBalance = checkingBalance - userWithdraw;

            Console.WriteLine("Your updated checking account balance is " + "$" + this.checkingBalance);
            Console.WriteLine();




        } 

        public override void Deposit(Account checkingAccount)
        {
            base.Deposit(checkingAccount);
            this.checkingBalance = checkingBalance + userDeposit;

            Console.WriteLine("Your updated checking account balance is " + "$" + this.checkingBalance);
            Console.WriteLine();

        } 



    }
}