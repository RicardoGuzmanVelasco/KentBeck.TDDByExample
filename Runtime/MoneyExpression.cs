namespace Domain
{
    public interface MoneyExpression
    {
        Money Reduce(string to);
    }
}