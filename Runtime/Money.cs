using System;

namespace Domain
{
    public abstract class Money
    {
        protected readonly int amount;

        protected Money(int amount) => this.amount = amount;
        public override bool Equals(object o)
        {
            return o is Money other &&
                   GetType() == other.GetType() &&
                   amount == other.amount;
        }

        public static Dollar Dollar(int amount) => null;
    }
}