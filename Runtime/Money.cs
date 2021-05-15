namespace Domain
{
    public abstract class Money
    {
        protected readonly int amount;

        protected Money(int amount) => this.amount = amount;
    }
}