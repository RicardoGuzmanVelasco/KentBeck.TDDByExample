namespace Domain
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency) {}

        public Money Times(int multiplier) => new Dollar(amount * multiplier, Currency);
    }
}