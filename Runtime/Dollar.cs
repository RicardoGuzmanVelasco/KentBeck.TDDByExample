namespace Domain
{
    public class Dollar : Money
    {
        public Dollar(int amount) : base(amount) { }

        public Dollar Times(int multiplier) => new Dollar(amount * multiplier);

        public override bool Equals(object o) => o is Dollar other && amount == other.amount;
    }
}