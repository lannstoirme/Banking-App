using System;
using SplashKitSDK;
using System.Collections.Generic;

public class DepositTransaction
{
     private Account _account;
     private decimal _amount;

      private bool _executed = false;
      private bool _success = false;
      private bool _reversed = false;

      public bool Success 
      {
          get{
              return _success;
          }
      }

     public bool Reversed
     {
         get{
             return _reversed;
         }
     }

     public bool Executed
     {
         get{
            return _executed;
         }
      }


public DepositTransaction(Account account, decimal amount)
{
    _account = account;
    _amount = amount;
}




      



public void Execute()
{
    if ( _executed )
    {
        throw new Exception("Cannot execute this transaction as it has already occurred");
    }
    _executed = true;
    _success = _account.Deposit(_amount);
}

public void Rollback()
{
    if (_executed)
    {
        throw new Exception("This transaction has not occurred");
    }
    _executed = false;
    _success = _account.Deposit(_amount);
    if (_executed)
        {
        throw new Exception("The transaction has been reversed");
    }
    _executed = true;
    _success = _account.Withdraw(_amount);
    if (_reversed)
    {
    throw new Exception("The transaction has been successfully reversed");
    }
    _reversed = true;
    Execute();
}

}