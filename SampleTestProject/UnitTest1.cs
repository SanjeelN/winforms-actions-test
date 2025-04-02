using SampleConsoleApp;

namespace SampleTestProject
{
    [Category("SampleTest1")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PassingTest()
        {
            Assert.Pass();
        }

        [Test]
        public void PassingTest2()
        {
            Assert.Pass();
        }
        
        [Test]
        public void CalculatorTest()
        {
            var calculator = new Calculator();
            var result = calculator.Add(5, 10);
            Assert.That(result == 15, "This will pass");
        }
        
        
    }
}
