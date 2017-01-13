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
            Check.That(new BankAccount(new Client("Dupont"))).IsEqualTo(new BankAccount(new Client("Dupont"), new Amount(0)));
        }

        [Fact]
        public void Deposite5OnEmptyBankAccountShouldReturnBankAccountWith5()
        {
            Check.That(new BankAccount(new Client("Dupont")).Deposite(new Amount(5))).IsEqualTo(new BankAccount(new Client("Dupont"), new Amount(5)));
        }

        [Fact]
        public void Withdrawal5OnEmptyBankAccountShouldReturnNegativeBankAccountOf5()
        {
            Check.That(new BankAccount(new Client("Dupont")).Withdrawal(new Amount(5))).IsEqualTo(new BankAccount(new Client("Dupont"), new Amount(-5)));
        }

        [Fact]
        public void Deposite41OnBankAccountWith1ToCurrentAmountShouldBeEqualToBankAccountWIth42()
        {
            Check.That(new BankAccount(new Client("Dupont"), new Amount(1)).Deposite(new Amount(41)))
                .IsEqualTo(new BankAccount(new Client("Dupont"), new Amount(42)));
        }

        [Fact]
        public void Tranfert5ToAnotherBankAccountShouldBeSubstract5ToThisBankAccount()
        {
            var firstClient = new Client("Dupont");
            var secondClient = new Client("Martin");
            var firstBankAccount = new BankAccount(firstClient, new Amount(25.99m));
            var secoundBankAccount = new BankAccount(secondClient);

            Check.That(firstBankAccount.Transfert(new Amount(16), secoundBankAccount)).IsEqualTo(new BankAccount(firstClient, new Amount(9.99m)));
        }
    }
}
