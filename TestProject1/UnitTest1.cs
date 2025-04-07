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
    }
}