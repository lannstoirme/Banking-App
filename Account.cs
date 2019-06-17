using System;
using SplashKitSDK;
using System.Collections.Generic;

public class Account
{
    private decimal _balance;
    private string _name;

    private decimal amountToAdd;

    private decimal amountToSubtract;

    


        public Account(string name, decimal startingBalance)
        {
            _name = name;
            _balance = startingBalance;            
        }

            
        
        public bool Deposit(decimal amountToAdd)
        {
            if (amountToAdd >0)
            {
            _balance = _balance + amountToAdd;
            return true;
            }
            return false;
        }

        

        public bool Withdraw(decimal amountToSubtract)
        {
    
            if ((amountToSubtract > 0) && (_balance > amountToSubtract));
            {
            _balance = _balance - amountToSubtract; 
            return true;
            }
            return false;
            Console.WriteLine("Transaction cannot be completed as withdrawal amount is greater than balance");
        }

        public string GetName
        {
           get { return _name; }
        }

/*public class Print
{
    public string accountname;
    public decimal newbalance;
        public Print(string name, decimal _balance)
        {
            accountname = name;
            newbalance = _balance;
            Console.WriteLine("Your new account balance for " + accountname + "account is " + newbalance);
        }
        
}    */
        
}





