using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Reserve : Account
    {
        //fields

        public double reserveBalance = 750;
        private string acctType = "reserve";

        //properties

        private double ReserveBalance
        { get;
            set; }

        private string Type
        { get;
            set; }

        //constructor 

        public Reserve()
        {
            // do i need something here?  if errors...check here  
        }



        //methods

        public void CurrentReserveBalance()
        {
            Console.WriteLine("The balance in your reserve account is " + reserveBalance);
            Console.WriteLine();
        }




        public override void Withdraw(Account reserveAccount)
        {
            base.Withdraw(reserveAccount);
            this.reserveBalance = reserveBalance - userWithdraw;

            Console.WriteLine("Your new reserve account balance is " + "$" + this.reserveBalance);
            Console.WriteLine();

        } 



        public override void Deposit(Account reserveAccount)
        {
            base.Deposit(reserveAccount);
            this.reserveBalance = reserveBalance + userDeposit;

            Console.WriteLine("Your updated reserve balance is " + "$" + this.reserveBalance);
            Console.WriteLine();

        } 


    }
} 