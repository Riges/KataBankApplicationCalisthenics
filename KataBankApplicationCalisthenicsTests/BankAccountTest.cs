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
            Check.That(new BankAccount().GetBalance()).IsEqualTo(new Amount(0));
        }

        [Fact]
        public void Deposite5ShouldReturn5ToBalance()
        {
            Check.That(new BankAccount().Deposite(new Amount(5)).GetBalance()).IsEqualTo(new Amount(5));
        }
    }
}
