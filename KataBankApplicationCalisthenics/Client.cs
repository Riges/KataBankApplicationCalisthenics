namespace KataBankApplicationCalisthenicsTests
{
    public class Client
    {
        private readonly string name;

        public Client(string name)
        {
            this.name = name;
        }

        public override bool Equals(object other)
        {
            var that = other as Client;
            return that?.name == name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}