using System;

namespace UnitTestingExamples.Library
{
	/// <summary>
	/// Bank account.
	/// </summary>
	public class BankAccount
	{
		private double m_balance = 0.0;

		public void Deposit(double amount)
		{
			m_balance += amount;
		}

		public double Balance
		{
			get { return m_balance; }
		}

		public void Withdraw(double amount)
		{
			m_balance -= amount;
		}

		public void TransferFunds(BankAccount destination, double amount)
		{
			destination.Deposit(amount);
			Withdraw(amount);
		}
	}
}
