using FluentAssertions;
using NUnit.Framework;

namespace Domain.Tests
{
    public class CurrencyTests
    {
        [Test]
        public void Dollar_Multiplication()
        {
            var sut = new Dollar(5);

            var result1 = sut.Times(2);
            var result2 = sut.Times(3);
            
            result1.Amount.Should().Be(10);
            result2.Amount.Should().Be(15);
        }
    }
}