using FluentAssertions;
using NUnit.Framework;

namespace Domain.Tests
{
    public class BankTests
    {
        [Test]
        public void Rate_OnSameCurrency_ReturnsIdentity()
        {
            var sut = new Bank();

            var result = sut.Rate("USD", "USD");

            result.Should().Be(1);
        }
        
        [Test]
        public void Reduce_OnMulticurrency_ReturnsByRate()
        {
            var sut = new Bank();
            sut.AddRate("CHF", "USD", 2);

            var result = sut.Reduce(Money.Franc(2), "USD");
            result.Should().Be(Money.Dollar(1));
        }
        
        [Test]
        public void Reduce_Sum_OnSameCurrency_ReturnsMoneySum()
        {
            var sum = new SumExpression(Money.Dollar(3), Money.Dollar(4));
            var sut = new Bank();

            var result = sut.Reduce(sum, "USD");

            result.Should().Be(Money.Dollar(7));
        }
    }
}