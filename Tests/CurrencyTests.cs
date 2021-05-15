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

        [Test]
        public void Dollar_Equality()
        {
            var sut1 = new Dollar(5);
            var sut2 = new Dollar(5);

            sut1.Should().Be(sut2);
        }
        
        [Test]
        public void Dollar_Unequality()
        {
            var sut1 = new Dollar(5);
            var sut2 = new Dollar(6);

            sut1.Should().NotBe(sut2);
        }
    }
}