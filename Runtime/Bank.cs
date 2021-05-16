using System.Collections.Generic;

namespace Domain
{
    public class Bank
    {
        Dictionary<CurrencyPair, int> rates;
        
        public Money Reduce(MoneyExpression source, string to) => source.Reduce(this, to);

        public void AddRate(string from, string to, int rate)
        {
            
        }

        public int Rate(string from, string to) => rates[new CurrencyPair(@from, to)];
    }
}