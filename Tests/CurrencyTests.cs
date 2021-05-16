using System.Linq.Expressions;
using FluentAssertions;
using NUnit.Framework;

namespace Domain.Tests
{
    public class CurrencyTests
    {
        [Test]
        public void MixedCurrency_Addition()
        {
            //Arrange
            var dollars = Money.Dollar(5);
            var francs = Money.Franc(10);
            
            var sut = new Bank();
            sut.AddRate(francs.Currency, dollars.Currency, 2);

            //Act
            var result = sut.Reduce(dollars.Plus(francs), dollars.Currency);

            //Assert
            result.Should().Be(Money.Dollar(10));
        }
        
        [Test]
        public void Plus_ReturnsASumExpression()
        {
            var sut = Money.Dollar(5);
            
            var sum = sut.Plus(sut);

            sum.Augend.Should().Be(Money.Dollar(5));
            sum.Addend.Should().Be(Money.Dollar(5));
        }
        
        [Test]
        public void Bank_MoneyExpression_Reduction()
        {
            var money = Money.Dollar(5);
            var sum = money.Plus(money);
            var sut = new Bank();

            var resultReduced = sut.Reduce(sum, "USD");

            resultReduced.Should().Be(Money.Dollar(10));
        }

        [Test]
        public void Bank_Money_Reduction()
        {
            var money = Money.Dollar(1);
            var sut = new Bank();

            var result = sut.Reduce(money, "USD");

            result.Should().Be(Money.Dollar(1));

        }
        
        [Test]
        public void Currency_Codes()
        {
            Money.Dollar(1).Currency.Should().Be("USD");
            Money.Franc(1).Currency.Should().Be("CHF");
        }
        
        [Test]
        public void Money_Multiplication()
        {
            var sut = Money.Dollar(5);

            var result1 = sut.Times(2);
            var result2 = sut.Times(3);
            
            result1.Should().Be(Money.Dollar(10));
            result2.Should().Be(Money.Dollar(15));
        }
        
        [Test]
        public void Money_Equality()
        {
            var sut = Money.Dollar(5);

            sut.Should().Be(Money.Dollar(5));
        }
        
        [Test]
        public void Money_Inequality()
        {
            var sut = Money.Dollar(5);

            sut.Should().NotBe(Money.Dollar(6));
        }
        
        [Test]
        public void Dollar_Franc_Inequality()
        {
            Money sut1 = Money.Dollar(5);
            Money sut2 = Money.Franc(5);

            sut1.Should().NotBe(sut2);
        }
    }
}