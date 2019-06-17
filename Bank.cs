using System;
using SplashKitSDK;
using System.Collections.Generic;
using System.Linq;

public class Bank
{
    private List<Account> _accounts = new List<Account>();

    public void AddAccount(Account account)
    {
        _accounts.Add(account);
    }

    public Account GetAccount(String name)
    {
        foreach (Account Acc in _accounts)
        {
            if (name == Acc.GetName)
            {
                return Acc;
            }
        }
        return null;
    }
    
    public void ExecuteTransaction(WithDrawTransaction transaction)
    {
        transaction.Execute();
    }

    public void ExecuteTransaction(DepositTransaction transaction)
    {
        transaction.Execute();
    }

    public void ExecuteTransaction(TransferTransaction transaction)
    {
        transaction.Execute();
    }
    public static void AddAccount(string _accountname, decimal _newBalance)
    {
        int numberofaccounts;
        List<string> _accounts = new List<string> ();
        List<decimal> _balance = new List<decimal> ();
        Console.WriteLine("How many accounts would you like to add to the bank?");
        numberofaccounts = Convert.ToInt32(Console.ReadLine());

        int i = 0;
        while (i < numberofaccounts)
        {
            Console.WriteLine("Please add the name for the new account");
            _accounts.Add(Console.ReadLine());
            Console.WriteLine("Please enter the starting balance of your account");
            _balance.Add(Convert.ToDecimal(Console.ReadLine()));
            i++;
        } 
            _accounts.ForEach(Console.WriteLine);
            _balance.ForEach(Console.WriteLine);
            
    }

   
     
        
}
