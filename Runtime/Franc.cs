namespace Domain
{
    public class Franc : Money
    {
        public override string Currency => null;

        public Franc(int amount) : base(amount)  { }

        public override Money Times(int multiplier) => new Franc(amount * multiplier);
    }
}