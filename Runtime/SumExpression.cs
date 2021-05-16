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
    }
}