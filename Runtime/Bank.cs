namespace Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression source, string to)
        {
            if(source is Money money)
                return money;
            
            var sum = (SumExpression) source;
            return sum.Reduce(to);
        }
    }
}