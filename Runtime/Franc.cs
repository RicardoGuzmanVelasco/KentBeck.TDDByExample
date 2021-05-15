namespace Domain
{
    public class Franc : Money
    {
        public Franc(int amount) : base(amount)  { }

        public Franc Times(int multiplier) => new Franc(amount * multiplier);
    }
}