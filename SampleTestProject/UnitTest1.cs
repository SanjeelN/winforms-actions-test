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
    }
}
