using BankAccountNS;

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

            Assert.That(account.Balance, Is.EqualTo(beginningBalance));
            Assert.That(account.CustomerName, Is.EqualTo("Sanjeel"));
        }
    }
}