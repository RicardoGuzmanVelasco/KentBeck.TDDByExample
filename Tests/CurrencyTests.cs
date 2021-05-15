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
            
            result1.Should().Be(new Dollar(10));
            result2.Should().Be(new Dollar(15));
        }
        
        [Test]
        public void Dollar_Equality()
        {
            var sut = new Dollar(5);

            sut.Should().Be(new Dollar(5));
        }
        
        [Test]
        public void Dollar_Unequality()
        {
            var sut = new Dollar(5);

            sut.Should().NotBe(new Dollar(6));
        }
    }
}