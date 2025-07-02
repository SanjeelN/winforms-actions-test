using BankAccountNS;
using ConsoleApp;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PassingTest()
        {
            // Arrange
            double beginningBalance = 11.99;
            BankAccount account = new BankAccount("Sanjeel", beginningBalance);

            Assert.Fail("This test is not supposed to fail");
            Assert.That(account.Balance, Is.EqualTo(beginningBalance));
            Assert.That(account.CustomerName, Is.EqualTo("Sanjeel"));
        }

        [Test]
        public void AdditionTest()
        {
            var calc = new Calc();
            var result = calc.Add(5, 5);
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void MultiplicationTest()
        {
            var calc = new Calc();
            var result = calc.Multiply(4, 6);
            Assert.That(result, Is.EqualTo(24));
        }
    }
}