namespace Domain
{
    public class Franc
    {
        int Amount { get; }
        
        public Franc(int amount) => Amount = amount;

        public Franc Times(int multiplier) => new Franc(Amount * multiplier);

        public override bool Equals(object o) => o is Franc other && Amount == other.Amount;
    }
}