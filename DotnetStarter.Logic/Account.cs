using System;
using ApprovalUtilities.Utilities;

namespace DotnetStarter.Logic.Tests;

public class Transaction
{
    public DateTime TransactionDate { get; set; }
    public int Amount { get; set; }

    public string PrintLine()
    {
        return $"{TransactionDate.ToString("dd.MM.yyyy")} +{Amount}      {Amount}";
    }
}

public class Account
{
    private readonly Transaction transaction = new Transaction();

    public void Deposit(int amount)
    {
        transaction.TransactionDate = DateGetter();
        transaction.Amount = amount;
    }

    public string PrintStatement()
    {
        var tab = "\t";
        return $@"
                Date       Amount    Balance
                {transaction.PrintLine()}

    ".RemoveIndentation();
    }

    public void SetDateGetter(Func<DateTime> func)
    {
        DateGetter = func;
    }

    public Func<DateTime> DateGetter { get; set; }
}