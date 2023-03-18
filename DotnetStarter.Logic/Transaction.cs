using System;

namespace DotnetStarter.Logic.Tests;

public class Transaction
{
    public DateTime TransactionDate { get; set; }
    public int Amount { get; set; }
    public int Balance { get; set; }

    public string PrintLine()
    {
        var plus = "+";
        var minus = "-";
        if (IsWithdraw && Amount < 0)
        {
            return $"{TransactionDate.ToString("dd.MM.yyyy")} {Amount}      {Balance}";
        }
        return $"{TransactionDate.ToString("dd.MM.yyyy")} {(IsWithdraw ? minus : plus)}{Amount}      {Balance}";
    }

    public bool IsWithdraw { get; set; }
}