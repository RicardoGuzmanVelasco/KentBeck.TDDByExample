namespace Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression source, string to) => source.Reduce(this, to);

        public void AddRate(string source, string to, int rate)
        {
            
        }
    }
}