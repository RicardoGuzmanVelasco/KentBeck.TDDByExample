namespace Domain
{
    public class Dollar : Money
    {

        public Dollar(int amount, string currency) : base(amount, currency) {}

        public override Money Times(int multiplier) => Dollar(amount * multiplier);
    }
}