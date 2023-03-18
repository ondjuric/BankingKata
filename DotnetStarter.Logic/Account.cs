using System;
using System.Collections.Generic;
using System.Linq;
using ApprovalUtilities.Utilities;

namespace DotnetStarter.Logic.Tests;

public class Account
{
    private readonly List<Transaction> _transactions = new ();

    public void Deposit(int amount)
    {
        var transaction = new Transaction();
        var currentTransaction = _transactions.Count != 0 ? _transactions[_transactions.Count-1] : transaction;
        transaction.IsWithdraw = false;
        
        transaction.TransactionDate = DateGetter();
        transaction.Amount = amount;
        transaction.Balance = currentTransaction.Balance + amount;
        _transactions.Add(transaction);
    }

    public string PrintStatement()
    {
        var text = $"Date       Amount    Balance\n";
        text = text + _transactions.Select(t => t.PrintLine()).JoinWith("\n");
        return text + "\n";
    }

    public void SetDateGetter(Func<DateTime> func)
    {
        DateGetter = func;
    }

    public Func<DateTime> DateGetter { get; set; }

    public void Withdraw(int amount)
    {
        var transaction = new Transaction();
        var currentTransaction = _transactions.Count != 0 ? _transactions[_transactions.Count - 1] : transaction;
        transaction.IsWithdraw = true;
        
        transaction.TransactionDate = DateGetter();
        transaction.Amount -= amount;
        transaction.Balance = currentTransaction.Balance - amount;
        _transactions.Add(transaction);
    }
}