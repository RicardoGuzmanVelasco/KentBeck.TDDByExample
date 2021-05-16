namespace Domain
{
    public interface MoneyExpression
    {
        Money Reduce(Bank bank, string to);
        MoneyExpression Plus(MoneyExpression addend);
        MoneyExpression Times(int multiplier);
    }
}