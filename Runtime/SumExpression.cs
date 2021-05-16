namespace Domain
{
    public class SumExpression : MoneyExpression
    {
        public Money Augend { get; }
        public Money Addend { get; }

        public SumExpression(Money augend, Money addend)
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