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
    }
}
