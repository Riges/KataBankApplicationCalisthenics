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
            return that?.value == value;
        }

        public override string ToString()
        {
            return $"Amount({value})";
        }

        public Amount Subtract(Amount otherAmount)
        {
            return new Amount(value - otherAmount.value);
        }

        public Amount Add(Amount otherAmount)
        {
            return new Amount(value + otherAmount.value);
        }
    }
}