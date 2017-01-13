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
    }
}
