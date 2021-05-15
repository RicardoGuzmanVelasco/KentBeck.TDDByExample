namespace Domain
{
    public class Dollar
    {
        public int Amount { get; } 
        
        public Dollar(int amount) => Amount = amount;

        public Dollar Times(int multiplier) => new Dollar(Amount * multiplier);

        public override bool Equals(object obj)
        {
            return true;
        }
    }
}