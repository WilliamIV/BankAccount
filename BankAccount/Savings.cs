using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Savings : Account
    {


        
        //fields

        public double savingsBalance = 950;
        private string acctType = "savings";

        //properties

        private double SavingsBalance
        { get;
            set; }

        private string Type
        { get;
            set; }


        //constructor 

        public Savings()
        {
            // do i need something here?  if errors...check here       
        }



        //methods

        public void CurrentSavingsBalance()
        {
            Console.WriteLine("The balance of your savings account is " + savingsBalance);
            Console.WriteLine();


        }

        public override void Withdraw(Account savingsAccount)
        {
            base.Withdraw(savingsAccount);
            this.savingsBalance = savingsBalance - userWithdraw;

            Console.WriteLine("The updated savings account balance is " + "$" + this.savingsBalance);
            Console.WriteLine();

        } 

        public override void Deposit(Account savingsAccount)
        {
            base.Deposit(savingsAccount);
            this.savingsBalance = savingsBalance + userDeposit;

            Console.WriteLine("Your updated savings account balance is " + "$" + this.savingsBalance);
            Console.WriteLine();
        } 


    }

}