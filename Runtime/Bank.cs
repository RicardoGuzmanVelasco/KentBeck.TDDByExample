namespace Domain
{
    public class Bank
    {
        public Money Reduce(MoneyExpression source, string to)
        {
            var sum = (SumExpression) source;
            var amount = sum.Augend.Amount + sum.Addend.Amount;
            return new Money(amount, to);
        }
    }
}