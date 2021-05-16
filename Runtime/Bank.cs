namespace Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression source, string to)
        {
            var sum = (SumExpression) source;
            return sum.Reduce(to);
        }
    }
}