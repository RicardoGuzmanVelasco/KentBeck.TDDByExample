namespace Domain
{
    public abstract class Money
    {
        protected readonly int amount;

        protected Money(int amount) => this.amount = amount;
        public override bool Equals(object o) => o is Money other && amount == other.amount;
    }
}