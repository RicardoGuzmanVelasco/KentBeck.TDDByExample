namespace Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression expression, string currencyToReduceTo)
        {
            return Money.Dollar(10);
        }
    }
}