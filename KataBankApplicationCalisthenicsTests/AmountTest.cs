using KataBankApplicationCalisthenics;
using NFluent;
using Xunit;

namespace KataBankApplicationCalisthenicsTests
{
    public class AmountTest
    {
        [Fact]
        public void SameAmountIsEqual()
        {
            Check.That(new Amount(42)).IsEqualTo(new Amount(42));
        }

        [Fact]
        public void DiffrentAmountIsNotEqual()
        {
            Check.That(new Amount(0)).IsNotEqualTo(new Amount(42));
        }

        [Fact]
        public void DifferentObjectTypeIsNotEqualToAnyAmount()
        {
            Check.That(new Amount(42)).IsNotEqualTo(42);
        }

        [Fact]
        public void AmountStringifyShouldBeReadable()
        {
            Check.That(new Amount(42).ToString()).IsEqualTo("Amount(42)");
        }
    }
}