using System;
using ApprovalUtilities.Utilities;

namespace DotnetStarter.Logic.Tests;

public class Account
{
    public void Deposit(int amount)
    {
            
    }

    public string PrintStatement()
    {
        var tab = "\t";
        return $@"
                Date       Amount    Balance
                24.12.2015 +500      500

    ".RemoveIndentation();
    }

    public string Amount { get; set; }

    public void SetDateGetter(Func<DateTime> func)
    {
            
    }
}