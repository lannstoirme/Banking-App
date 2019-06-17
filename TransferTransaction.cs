using System;
using SplashKitSDK;

public class TransferTransaction{
     private Account _account;
     private decimal _amount;

     private Account _receivingaccount;
     

     private decimal _amounttotransfer;
     private decimal _startingBalanceB;

     private decimal _newBalance;

     private bool _executed = false;
     private bool _success = false;

      


public TransferTransaction(Account account, decimal amount)
{
    _account = account;
    _amount = amount;
}

public void TransferExecute(Account nameb, decimal amountb)
{
    _receivingaccount = nameb;
    _startingBalanceB = amountb;

    Console.WriteLine("What is the transfer amount you wish to make?");
   _amounttotransfer = Convert.ToDecimal(Console.ReadLine());
   _newBalance = _startingBalanceB + _amounttotransfer; 
   Execute();

}

public void Execute()
{
    if ( _executed )
    {
        throw new Exception("Cannot execute this transaction as it has already occurred");
    }
    _executed = true;
    _success = _account.Withdraw(_amount);
}




public void Print()
{
    Console.WriteLine("You have transferred from Account Name: " + _account + " to this Account Name: " + _receivingaccount);
    Console.WriteLine("You deposited " + _amounttotransfer);
    Console.WriteLine("The new balance of the receiving account is " + _newBalance);
}
}