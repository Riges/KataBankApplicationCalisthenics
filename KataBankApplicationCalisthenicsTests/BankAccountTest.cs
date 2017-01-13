using KataBankApplicationCalisthenics;
using NFluent;
using Xunit;

namespace KataBankApplicationCalisthenicsTests
{
    public class BankAccountTest
    {
        [Fact]
        public void EmptyAccountShouldBeEqualToBankAccountWith0()
        {
            Check.That(new BankAccount()).IsEqualTo(new BankAccount(new Amount(0)));
        }

        [Fact]
        public void Deposite5OnEmptyBankAccountShouldReturnBankAccountWith5()
        {
            Check.That(new BankAccount().Deposite(new Amount(5))).IsEqualTo(new BankAccount(new Amount(5)));
        }

        [Fact]
        public void Withdrawal5OnEmptyBankAccountShouldReturnNegativeBankAccountOf5()
        {
            Check.That(new BankAccount().Withdrawal(new Amount(5))).IsEqualTo(new BankAccount(new Amount(-5)));
        }

        [Fact]
        public void Deposite41OnBankAccountWith1ToCurrentAmountShouldBeEqualToBankAccountWIth42()
        {
            Check.That(new BankAccount(new Amount(1)).Deposite(new Amount(41)))
                .IsEqualTo(new BankAccount(new Amount(42)));
        }
    }
}
