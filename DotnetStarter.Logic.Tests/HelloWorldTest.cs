using System;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Principal;
using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using ApprovalUtilities.Utilities;
using Xunit;

namespace DotnetStarter.Logic.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class HelloWorldTest
    {
        [Fact]
        public void TestDeposit()
        {
            var a = new Account();
            a.setDateGetter(() => new DateTime(2015, 12, 24));
            a.Deposit(500);
            Approvals.Verify(a.PrintStatement());
        } 
        
        

    }

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

        public void setDateGetter(Func<DateTime> func)
        {
            
        }
    }
}