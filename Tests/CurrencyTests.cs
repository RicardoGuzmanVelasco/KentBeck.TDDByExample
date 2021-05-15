using FluentAssertions;
using NUnit.Framework;

namespace Domain.Tests
{
    public class CurrencyTests
    {
        [Test]
        public void Franc_Multiplication()
        {
            var sut = new Franc(5);

            var result1 = sut.Times(2);
            var result2 = sut.Times(3);
            
            result1.Should().Be(new Franc(10));
            result2.Should().Be(new Franc(15));
        }
        
        [Test]
        public void Dollar_Multiplication()
        {
            Money sut = Money.Dollar(5);

            var result1 = sut.Times(2);
            var result2 = sut.Times(3);
            
            result1.Should().Be(Money.Dollar(10));
            result2.Should().Be(Money.Dollar(15));
        }
        
        [Test]
        public void Dollar_Equality()
        {
            var sut = Money.Dollar(5);

            sut.Should().Be(Money.Dollar(5));
        }
        
        [Test]
        public void Dollar_Inequality()
        {
            var sut = Money.Dollar(5);

            sut.Should().NotBe(Money.Dollar(6));
        }
        
        [Test]
        public void Franc_Equality()
        {
            var sut = new Franc(5);

            sut.Should().Be(new Franc(5));
        }
        
        [Test]
        public void Franc_Inequality()
        {
            var sut = new Franc(5);

            sut.Should().NotBe(new Franc(6));
        }

        [Test]
        public void Dollar_Franc_Inequality()
        {
            Money sut1 = Money.Dollar(5);
            Money sut2 = new Franc(5);

            sut1.Should().NotBe(sut2);
        }
    }
}