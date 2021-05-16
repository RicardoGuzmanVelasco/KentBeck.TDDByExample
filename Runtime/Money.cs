using UnityEditor.UIElements;

namespace Domain
{
    public class Money : MoneyExpression
    {
        protected readonly int amount;
        
        public string Currency { get; }

        public Money(int amount, string currency)
        {
            this.amount = amount;
            Currency = currency;
        }

        public Money Times(int multiplier) => new Money(amount * multiplier, Currency);
        
        public static Money Dollar(int amount) => new Money(amount, "USD");
        public static Money Franc(int amount) => new Money(amount, "CHF");

        public SumExpression Plus(Money addend) => new SumExpression(this, addend);

        public override bool Equals(object o)
        {
            return o is Money other &&
                   Currency == other.Currency &&
                   amount == other.amount;
        }

        public override string ToString() => $"{nameof(amount)}: {amount}, {nameof(Currency)}: {Currency}";
    }
}