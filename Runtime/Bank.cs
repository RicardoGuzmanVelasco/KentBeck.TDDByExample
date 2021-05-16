using System.Collections.Generic;

namespace Domain
{
    public class Bank
    {
        readonly Dictionary<CurrencyPair, int> rates = new Dictionary<CurrencyPair, int>();
        
        public Money Reduce(MoneyExpression source, string to) => source.Reduce(this, to);

        public void AddRate(string from, string to, int rate)
        {
            rates[new CurrencyPair(from, to)] = rate;
        }

        public int Rate(string from, string to)
        {
            return @from == to
                    ? 1
                    : rates[new CurrencyPair(@from, to)];
        }
    }
}