namespace Domain
{
    public class Dollar : Money
    {

        public Dollar(int amount, string currency) : base(amount) => Currency = "USD";

        public override Money Times(int multiplier) => new Dollar(amount * multiplier, null);
    }
}