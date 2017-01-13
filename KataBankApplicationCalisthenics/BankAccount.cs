using System;

namespace KataBankApplicationCalisthenics
{
    public class BankAccount
    {
        private readonly Amount currentAmount;

        public BankAccount()
        {
            currentAmount = new Amount(0);
        }

        private BankAccount(Amount amount)
        {
            currentAmount = amount;
        }

        public Amount GetBalance()
        {
            return currentAmount;
        }

        public BankAccount Deposite(Amount amount)
        {
            return new BankAccount(amount);
        }
    }
}
