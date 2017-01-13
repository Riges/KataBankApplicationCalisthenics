using KataBankApplicationCalisthenics;
using NFluent;
using Xunit;

namespace KataBankApplicationCalisthenicsTests
{
    public class BankAccountTest
    {
        [Fact]
        public void EmptyAccountShouldHave0ToBalance()
        {
            Check.That(new BankAccount()).IsEqualTo(new BankAccount(new Amount(0)));
        }

        [Fact]
        public void Deposite5OnEmptyBankAccountShouldReturn5ToBalance()
        {
            Check.That(new BankAccount().Deposite(new Amount(5))).IsEqualTo(new BankAccount(new Amount(5)));
        }
    }
}
