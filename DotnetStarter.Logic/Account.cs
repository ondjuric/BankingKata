using System;
using ApprovalUtilities.Utilities;

namespace DotnetStarter.Logic.Tests;

public class Account
{
    public void Deposit(int amount)
    {
        TransactionDate = DateGetter();
        Amount = amount;
    }

    public string PrintStatement()
    {
        var tab = "\t";
        return $@"
                Date       Amount    Balance
                {TransactionDate.ToString("dd.MM.yyyy")} +{Amount}      {Amount}

    ".RemoveIndentation();
    }

    public DateTime TransactionDate { get; set; }

    public int Amount { get; set; }

    public void SetDateGetter(Func<DateTime> func)
    {
        DateGetter = func;
    }

    public Func<DateTime> DateGetter { get; set; }
}