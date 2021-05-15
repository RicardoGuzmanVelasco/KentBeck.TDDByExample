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

            sut.Times(2);

            sut.Amount.Should().Be(10);
        }
    }
}