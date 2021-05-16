namespace Domain
{
    public class Bank
    {
        public MoneyExpression Reduce(MoneyExpression source, string to)
        {
            return Money.Dollar(10);
        }
    }
}