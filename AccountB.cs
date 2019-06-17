using System;
using SplashKitSDK;

public class AccountB
{
    private decimal _balance;
    private string _name;

    


        public AccountB(string name, decimal startingBalance)
        {
            _name = name;
            _balance = startingBalance;
        }

        public void Deposit(decimal amountToAdd)
        {
            _balance = _balance + amountToAdd;
        }

        public void Withdraw(decimal amountToSubtract)
        {
            _balance = _balance - amountToSubtract;
        }

        public string Name
        {
            get { return _name; }
        }


        public void Print()
        {
            Console.WriteLine("Your account balance is: " + _balance);
            Console.WriteLine("Your account name is: " + Name);
        }



}