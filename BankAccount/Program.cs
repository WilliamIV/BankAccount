using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Account baseAccount = new Account();
            Checking checkingAccount = new Checking();
            Reserve reserveAccount = new Reserve();
            Savings savingsAccount = new Savings();

            StreamWriter checking = new StreamWriter("checking.txt", true);
            checking.WriteLine("Hilary Clinton \n 2017\n Checking Account");
            checking.Close();

            StreamWriter reserve = new StreamWriter("reserve.txt", true);
            reserve.WriteLine("Hilary Clinton \n 2017\n Reserve Account");
            reserve.Close();

            StreamWriter savings = new StreamWriter("savings.txt", true);
            savings.WriteLine("Hilary Clinton \n 2017\n Savings Account");
            savings.Close();


            int userChoice = 1;
            do
            {

                // Start page
                Console.WriteLine("Hello, and welcome back to the bank of the People of the United States.  Please make a selection below.");
                Console.WriteLine("Please choose an option from the menu.");

                // do i need anything else in here?


                Console.WriteLine("1. Account Information");
                Console.WriteLine("2. Balance");
                Console.WriteLine("3. Withdrawl Money");
                Console.WriteLine("4. Deposit Money");
                Console.WriteLine("5. Exit");

                userChoice = int.Parse(Console.ReadLine());



                //start of user choices *come back and check if the desired flow doesnt go in order

                switch (userChoice)
                {
                    case 1:
                        baseAccount.CustomerDisplay();
                        break;

                    case 2:
                        Console.WriteLine("Which account would you like to know the balance of?");
                        Console.WriteLine("1. Checking Account");
                        Console.WriteLine("2. Reserve Account");
                        Console.WriteLine("3. Savings Account");


                        int acctChoice = int.Parse(Console.ReadLine());
                        switch (acctChoice)


                        {
                            case 1:
                                checkingAccount.CurrentCheckingBalance();
                                break;
                            case 2:
                                reserveAccount.CurrentReserveBalance();
                                break;
                            case 3:
                                savingsAccount.CurrentSavingsBalance();
                                break;

                        }

                        break;

                        

                    case 3:
                         

                        Console.WriteLine("Which account would you like to withdrawl from?");
                        Console.WriteLine("1. Checking Account");
                        Console.WriteLine("2. Reserve Account");
                        Console.WriteLine("3. Savings Account");
                        int withdrawChoice = int.Parse(Console.ReadLine());
                        switch (withdrawChoice)



                        {
                            case 1:

                                checkingAccount.Withdraw(checkingAccount);

                                break;


                            case 2:

                                reserveAccount.Withdraw(reserveAccount);
                                break;


                            case 3:

                                savingsAccount.Withdraw(savingsAccount);
                                break;

                        }
                        break;




                    case 4:
                        Console.WriteLine("Which account would you like to deposit to?");
                        Console.WriteLine("1. Checking Account");
                        Console.WriteLine("2. Reserve Account");
                        Console.WriteLine("3. Savings Account");


                        int depositChoice = int.Parse(Console.ReadLine());
                        switch (depositChoice)
                        {
                            case 1:
                                checkingAccount.Deposit(checkingAccount);
                                break;


                            case 2:

                                reserveAccount.Deposit(reserveAccount);
                                break;


                            case 3:

                                savingsAccount.Deposit(savingsAccount);
                                break;


                            default:
                                Console.WriteLine("Must be a number 1-3");
                                break;

                        }

                        break;


                    case 5:
                        Console.WriteLine("Thanks for stopping by the bank of the People of the United States.");
                        

                        Console.ReadLine();
                        Environment.Exit(0);

                        break;


                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;

                }

            } while (true);


        }
    }
}