namespace Domain
{
    public class Dollar : Money
    {
        public Dollar(int amount) : base(amount) { }

        public override Money Times(int multiplier) => new Dollar(amount * multiplier);
    }
}