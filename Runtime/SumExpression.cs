namespace Domain
{
    public class SumExpression : MoneyExpression
    {
        public MoneyExpression Augend { get; }
        public MoneyExpression Addend { get; }

        public SumExpression(MoneyExpression augend, MoneyExpression addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank, to).Amount +
                         Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }
    }
}