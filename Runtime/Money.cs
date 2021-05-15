namespace Domain
{
    public abstract class Money
    {
        protected readonly int amount;
        public abstract string Currency { get; }

        protected Money(int amount) => this.amount = amount;

        public abstract Money Times(int multiplier);
        
        public static Money Dollar(int amount) => new Dollar(amount);
        public static Money Franc(int amount) => new Franc(amount);
        
        public override bool Equals(object o)
        {
            return o is Money other &&
                   GetType() == other.GetType() &&
                   amount == other.amount;
        }
    }
}