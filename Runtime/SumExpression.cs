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

        public MoneyExpression Plus(MoneyExpression addend) => new SumExpression(this, addend);
        public MoneyExpression Times(int multiplier) => new SumExpression(Augend.Times(multiplier), Addend.Times(multiplier));

        public Money Reduce(Bank bank, string to)
        {
            var amount = Augend.Reduce(bank, to).Amount +
                         Addend.Reduce(bank, to).Amount;
            return new Money(amount, to);
        }

    }
}