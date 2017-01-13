using NFluent;
using Xunit;

namespace KataBankApplicationCalisthenicsTests
{
    public class ClientTest
    {
        [Fact]
        public void SameClientIsEqual()
        {
            Check.That(new Client("Dupont")).IsEqualTo(new Client("Dupont"));
        }

        [Fact]
        public void DiffrentClientIsNotEqual()
        {
            Check.That(new Client("Dupont")).IsNotEqualTo(new Client("Dupond"));
        }

        [Fact]
        public void DifferentObjectTypeIsNotEqualToAnyClient()
        {
            Check.That(new Client("Dupont")).IsNotEqualTo(42);
        }

        [Fact]
        public void ClientStringifyShouldBeReadable()
        {
            Check.That(new Client("Dupont").ToString()).IsEqualTo("Dupont");
        }
    }
}
