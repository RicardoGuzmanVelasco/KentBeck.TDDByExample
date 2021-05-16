namespace Domain
{
    public class Money : MoneyExpression
    {
        public int Amount { get; }
        public string Currency { get; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public MoneyExpression Times(int multiplier) => new Money(Amount * multiplier, Currency);
        
        public MoneyExpression Plus(MoneyExpression addend) => new SumExpression(this, addend);
        
        public static Money Dollar(int amount) => new Money(amount, "USD");
        public static Money Franc(int amount) => new Money(amount, "CHF");

        public Money Reduce(Bank bank, string to)
        {
            var rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }

        #region Equality
        public override bool Equals(object o)
        {
            return o is Money other &&
                   Currency == other.Currency &&
                   Amount == other.Amount;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Amount * 397) ^ (Currency != null ? Currency.GetHashCode() : 0);
            }
        }
        #endregion

        public override string ToString() => $"{nameof(Amount)}: {Amount}, {nameof(Currency)}: {Currency}";
    }
}