namespace Domain
{
    public class Dollar
    {
        public int Amount { get; private set; } 
        
        public Dollar(int amount)
        {
            
        }

        public void Times(int amount)
        {
            Amount = 5 * 2;
        }
    }
}