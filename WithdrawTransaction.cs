using System;
using SplashKitSDK;

public class WithDrawTransaction
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


public WithDrawTransaction(Account account, decimal amount)
{
    _account = account;
    _amount = amount;
    _success = false;
    _executed = false;
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

public void Rollback()
{
    if (_executed)
    {
        throw new Exception("This transaction has not occurred");
    }
    _executed = false;
    _success = _account.Withdraw(_amount);
    if (_executed)
        {
        throw new Exception("The transaction has been reversed");
    }
    _executed = false;
    _success = false;
    _reversed = true;
    
}
}