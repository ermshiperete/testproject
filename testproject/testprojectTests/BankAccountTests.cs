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
	}
}