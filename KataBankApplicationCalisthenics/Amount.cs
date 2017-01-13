namespace KataBankApplicationCalisthenics
{
    public class Amount
    {
        private readonly decimal value;

        public Amount(decimal value)
        {
            this.value = value;
        }

        public override bool Equals(object other)
        {
            var that = other as Amount;
            if (that != null)
            {
                return that.value == value;
            }

            return false;
        }
    }
}