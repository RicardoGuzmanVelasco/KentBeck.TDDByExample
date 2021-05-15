namespace Domain
{
    public class Dollar
    {
        readonly int amount;

        public Dollar(int amount) => this.amount = amount;

        public Dollar Times(int multiplier) => new Dollar(amount * multiplier);

        public override bool Equals(object o) => o is Dollar other && amount == other.amount;
    }
}