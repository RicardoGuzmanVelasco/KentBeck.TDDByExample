namespace Domain
{
    public class Money
    {
        protected readonly int amount;
        
        public string Currency { get; }

        public Money(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }

        public Money Times(int multiplier) => null;
        
        public static Dollar Dollar(int amount) => new Dollar(amount, "USD");
        public static Franc Franc(int amount) => new Franc(amount, "CHF");
        
        public override bool Equals(object o)
        {
            return o is Money other &&
                   Currency == other.Currency &&
                   amount == other.amount;
        }

        public override string ToString() => $"{nameof(amount)}: {amount}, {nameof(Currency)}: {Currency}";
    }
}