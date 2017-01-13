﻿using System;

namespace KataBankApplicationCalisthenics
{
    public class BankAccount
    {
        private readonly Amount currentAmount;

        public BankAccount()
        {
            currentAmount = new Amount(0);
        }

        public BankAccount(Amount amount)
        {
            currentAmount = amount;
        }

        public override bool Equals(object other)
        {
            var that = other as BankAccount;
            if (that != null)
            {
                var otherCurrentAmount = that.currentAmount;
                return otherCurrentAmount.Equals(currentAmount);
            }

            return false;
        }

        public override string ToString()
        {
            return $"BankAccount with {currentAmount}";
        }

        public BankAccount Deposite(Amount amount)
        {
            return new BankAccount(currentAmount.Add(amount));
        }

        public BankAccount Withdrawal(Amount amount)
        {
            return new BankAccount(currentAmount.Subtract(amount));
        }
    }
}
