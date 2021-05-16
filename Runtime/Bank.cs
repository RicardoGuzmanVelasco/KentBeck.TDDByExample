namespace Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression source, string to) => source.Reduce(to);

        public void AddRate(string source, string to, int rate)
        {
            
        }
    }
}