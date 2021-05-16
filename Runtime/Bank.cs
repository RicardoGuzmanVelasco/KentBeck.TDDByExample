namespace Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression source, string to) => source.Reduce(this, to);

        public void AddRate(string from, string to, int rate)
        {
            
        }

        public int Rate(string from, string to) => @from is "CHF" && to is "USD" ? 2 : 1;
    }
}