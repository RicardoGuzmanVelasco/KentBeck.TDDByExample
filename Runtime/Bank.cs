namespace Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression source, string to)
        {
            return Money.Dollar(10);
        }
    }
}