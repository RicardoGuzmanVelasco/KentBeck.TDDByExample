namespace Domain
{
    public class Franc : Money
    {
        int Amount { get; }
        
        public Franc(int amount) : base(amount) { }

        public Franc Times(int multiplier) => new Franc(Amount * multiplier);
    }
}