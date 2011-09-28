using System;
using NUnit.Framework;
using UnitTestingExamples.Library;

namespace UnitTestingExamples.Tests
{
	[TestFixture]
	public class BankAccountTests
	{
		[Test]
		public void TestDeposit()
		{
			BankAccount account = new BankAccount();
			account.Deposit(125.0);
			account.Deposit(25.0);
			Assert.AreEqual(150.0, account.Balance);
		}

		[Test]
		public void TestWithdraw()
		{
			BankAccount account = new BankAccount();
			account.Deposit(125.0);
			account.Withdraw(25.0);
			Assert.AreEqual(100.0, account.Balance);
		}

		[Test]
		public void TransferFunds()
		{
			BankAccount source = new BankAccount();
			source.Deposit(200.00);
			BankAccount destination = new BankAccount();
			destination.Deposit(150.00);

			source.TransferFunds(destination, 100.00);
			Assert.AreEqual(250.00, destination.Balance);
			Assert.AreEqual(100.00, source.Balance);
		}
	}
}
