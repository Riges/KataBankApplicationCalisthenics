using System;
using KataBankApplicationCalisthenicsTests;

namespace KataBankApplicationCalisthenics
{
    public class BankAccount
    {
        private readonly Amount currentAmount;
        private readonly Client client;

        public BankAccount()
        {
            currentAmount = new Amount(0);
        }

        public BankAccount(Amount amount)
        {
            currentAmount = amount;
        }

        public BankAccount(Client client)
        {
            this.client = client;
            currentAmount = new Amount(0);
        }

        public BankAccount(Client client, Amount amount)
        {
            this.client = client;
            currentAmount = amount;
        }

        public override bool Equals(object other)
        {
            var that = other as BankAccount;
            if (that != null)
            {
                var otherCurrentAmount = that.currentAmount;
                var otherClient = that.client;
                return otherCurrentAmount.Equals(currentAmount) && otherClient.Equals(client);
            }

            return false;
        }

        public override string ToString()
        {
            return $"BankAccount of {client} with {currentAmount}";
        }

        public BankAccount Deposite(Amount amount)
        {
            return new BankAccount(client, currentAmount.Add(amount));
        }

        public BankAccount Withdrawal(Amount amount)
        {
            return new BankAccount(client, currentAmount.Subtract(amount));
        }

        public BankAccount Transfert(Amount amount, BankAccount destinationBankAccount)
        {
            return new BankAccount(client, currentAmount.Subtract(amount));
        }
    }
}
