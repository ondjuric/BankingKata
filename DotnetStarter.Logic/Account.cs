using System;
using ApprovalUtilities.Utilities;

namespace DotnetStarter.Logic.Tests;

public class Account
{
    public void Deposit(int amount)
    {
        TransactionDate = DateGetter();
    }

    public string PrintStatement()
    {
        var tab = "\t";
        return $@"
                Date       Amount    Balance
                {TransactionDate} +500      500

    ".RemoveIndentation();
    }

    public DateTime TransactionDate { get; set; }

    public string Amount { get; set; }

    public void SetDateGetter(Func<DateTime> func)
    {
        DateGetter = func;
    }

    public Func<DateTime> DateGetter { get; set; }
}