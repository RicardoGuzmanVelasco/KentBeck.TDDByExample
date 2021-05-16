namespace Domain
{
    public class CurrencyPair
    {
        public readonly string fromCurrency;
        public readonly string toCurrency;

        public CurrencyPair(string fromCurrency, string toCurrency)
        {
            this.fromCurrency = fromCurrency;
            this.toCurrency = toCurrency;
        }

        #region Equality
        public override bool Equals(object o)
        {
            return o is CurrencyPair other &&
                   fromCurrency == other.fromCurrency &&
                   toCurrency == other.toCurrency;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((fromCurrency != null ? fromCurrency.GetHashCode() : 0) * 397) ^ (toCurrency != null ? toCurrency.GetHashCode() : 0);
            }
        }
        #endregion
    }
}