using BankAccountNS;
using ConsoleApp;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        
        [Test]
        public void AdditionTest()
        {
            var calc = new Calc();
            var result = calc.Add(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void ModulusTest()
        {
            var calc = new Calc();
            var result = calc.Modulus(3, 28);
            Assert.That(result, Is.EqualTo(3));
        }
        
        [Test]
        public void BankAccountTest()
        {
            var account = new BankAccount("John Doe", 1000.00);
            Assert.That(account.CustomerName, Is.EqualTo("John Doe"));
            Assert.That(account.Balance, Is.EqualTo(1000.00));
        }
    }
}