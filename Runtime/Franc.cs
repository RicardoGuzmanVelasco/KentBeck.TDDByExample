namespace Domain
{
    public class Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency) {}

        public Money Times(int multiplier) => new Franc(amount * multiplier, Currency);
    }
}