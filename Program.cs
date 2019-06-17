using System;
using SplashKitSDK;
using System.Collections.Generic;
using System.Linq;


public class BankTransactions
{
    public static void Main()
    {
        
        
        Bank bank = new Bank();
        
        
        MenuOption userSelection;

        do
        {

            userSelection = ReadUserOption();

            switch (userSelection)
            {
                case MenuOption.Withdraw:
                Console.WriteLine("You have chosen to make a withdrawal ...");
                DoWithdraw(bank);
                break;
                case MenuOption.Deposit:
                Console.WriteLine("You have chosen to make a deposit ...");
                DoDeposit(bank);
                break;
                case MenuOption.Transfer:
                DoTransfer(bank);
                break;
                case MenuOption.AddAccountt:
                Console.WriteLine("You have chosen to add an account ...");
                NewAccount(bank);
                break;
                case MenuOption.FindAccountt:
                Console.WriteLine("You have chosen to search for an account ...");
                FindAccount(bank);
                break;
                case MenuOption.Quit:
                Console.WriteLine("Quit ...");
                break;
                } 
        } while (userSelection != MenuOption.Quit);
        Console.WriteLine(userSelection); 

    }
        
        public static MenuOption ReadUserOption()
        {
        
                Console.WriteLine("Please choose from the the following:");
                Console.WriteLine("** 1 = Deposit **\n,** 2 = Withdraw **");
                Console.WriteLine("** 3 = Transfer **\n ** 4 = Add Account **");
                Console.WriteLine("** 5 = Search Account **\n ** 6 = Quit **");
                int option = Convert.ToInt32(Console.ReadLine());
                return (MenuOption)(option - 1);
               
        }

      
public static void DoDeposit(Bank bank)
        {
            decimal amountToDeposit;
            amountToDeposit = 0;
            Account toAccount = FindAccount(bank);
            if (toAccount == null) return;
            Console.WriteLine("Please enter your amount to Deposit");
            amountToDeposit = Convert.ToDecimal(Console.ReadLine());
            DepositTransaction accountDeposit = new DepositTransaction(toAccount, amountToDeposit);
            accountDeposit.Execute();
            accountDeposit.Print();
            }  

        

        private static void DoWithdraw(Bank bank)
        {
            decimal amountToWithdraw;
            Account fromAccount = FindAccount(bank);
            if (fromAccount == null) return;
            Console.WriteLine("Enter an amount to Withdraw?");
            WithDrawTransaction accountWithdraw = new WithDrawTransaction(fromAccount, amountToWithdraw);
            accountWithdraw.Execute();
            accountWithdraw.Print();    
        }

        private static void DoTransfer(Bank bank)
        {
            Account fromAccount = findAccount(bank);
            Account toAccount = FindAccount(bank);
            if ((fromAccount == null) || (toAccount == null)) return;
            Console.WriteLine("How much would you like to transfer?");
            TransferTransactions accountTransfer = new TransferTransactions(fromAccount, toAccount, transferAmount);
            accountTransfer.Execute();
            accountTransfer.Print();
        }

        private static Account FindAccount(Bank bank)
        {
            Console.Write("Enter account name: ");
            String name = Console.ReadLine();
            Account result = bank.GetAccount(name);
            if (result == null)
            {
                Console.WriteLine($"No account found with name {name}");
            }
            {
                Console.WriteLine($"No account found with name {name}");
            }
        }      

        private static void NewAccount(Bank bank)
        {
            decimal startingBalance = 0;
            Console.WriteLine("What's the name of the Account owner?");
            string accName = Console.ReadLine();
            Console.WriteLine("How much would you like to deposit?");
            startingBalance = Convert.ToDecimal(Console.ReadLine());
            Account newAcc = new Account(accName, startingBalance);
            bank.AddAccount(newAcc);
        }
        public static void Print(Account account, decimal amount)
        {
            Console.WriteLine("The balance for Account " +  account + " is " + amount);
        }
    
       
}

public enum MenuOption
{
    Withdraw,
    Deposit,
    Transfer,
    AddAccountt,
    FindAccountt,
    Quit
}
