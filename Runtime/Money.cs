namespace Domain
{
    public abstract class Money
    {
        protected readonly int amount;
        
        public string Currency { get; }

        protected Money(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }

        public abstract Money Times(int multiplier);
        
        public static Money Dollar(int amount) => new Dollar(amount, "USD");
        public static Money Franc(int amount) => new Franc(amount, "CHF");
        
        public override bool Equals(object o)
        {
            return o is Money other &&
                   GetType() == other.GetType() &&
                   amount == other.amount;
        }
    }
}