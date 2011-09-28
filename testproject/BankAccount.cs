using System;

namespace UnitTestingExamples.Library
{
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
			m_balance -= amount;
		}
	}
}
