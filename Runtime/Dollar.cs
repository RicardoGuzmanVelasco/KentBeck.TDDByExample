namespace Domain
{
    public class Dollar
    {
        public int Amount { get; private set; } 
        
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            Amount *= multiplier;
            return null;
        }
    }
}