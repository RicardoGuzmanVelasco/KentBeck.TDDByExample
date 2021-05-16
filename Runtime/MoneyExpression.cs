namespace Domain
{
    public interface MoneyExpression
    {
        Money Reduce(Bank bank, string to);
    }
}