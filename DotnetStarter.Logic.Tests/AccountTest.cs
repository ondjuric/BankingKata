using System;
using ApprovalTests;
using ApprovalTests.Reporters;
using Xunit;

namespace DotnetStarter.Logic.Tests
{
    [UseReporter(typeof(DiffReporter))]
    public class AccountTest
    {
        [Fact]
        public void TestDeposit()
        {
            var a = new Account();
            a.SetDateGetter(() => new DateTime(2015, 12, 24));
            a.Deposit(500);
            Approvals.Verify(a.PrintStatement());
        }
        
        [Fact]
        public void TestDepositDate()
        {
            var a = new Account();
            a.SetDateGetter(() => new DateTime(2015, 12, 25));
            a.Deposit(500);
            
            Approvals.Verify(a.PrintStatement());
        }
        
        [Fact]
        public void TestDepositDateAndAmount()
        {
            var a = new Account();
            a.SetDateGetter(() => new DateTime(2015, 12, 26));
            a.Deposit(600);
            
            Approvals.Verify(a.PrintStatement());
        }
        [Fact]
        public void Test2Deposits()
        {
            var a = new Account();
            int i = 1;
            a.SetDateGetter(() => new DateTime(2015, 12, i++));
            a.Deposit(600);
            a.Deposit(600);
            
            Approvals.Verify(a.PrintStatement());
        }
        
        [Fact]
        public void Test3Deposits()
        {
            var a = new Account();
            int i = 1;
            a.SetDateGetter(() => new DateTime(2015, 12, i++));
            a.Deposit(600);
            a.Deposit(600);
            a.Deposit(800);
            
            Approvals.Verify(a.PrintStatement());
        }
        
        [Fact]
        public void TestWithdraw()
        {
            var a = new Account();
            int i = 1;
            a.SetDateGetter(() => new DateTime(2015, 12, i++));
            a.Withdraw(600);
            
            Approvals.Verify(a.PrintStatement());
        }
        
        [Fact]
        public void TestDepositAndWithdraw()
        {
            var a = new Account();
            int i = 1;
            a.SetDateGetter(() => new DateTime(2015, 12, i++));
            a.Deposit(800);
            a.Withdraw(600);
            
            Approvals.Verify(a.PrintStatement());
        }
        
        [Fact]
        public void Test2DepositsAnd2Withdraw()
        {
            var a = new Account();
            int i = 1;
            a.SetDateGetter(() => new DateTime(2015, 12, i++));
            a.Deposit(800);
            a.Withdraw(600);
            a.Deposit(400);
            a.Withdraw(100);

            Approvals.Verify(a.PrintStatement());
        }
        
    }
    
}