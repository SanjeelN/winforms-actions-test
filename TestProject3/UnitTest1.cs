using System.Threading.Tasks;

namespace TestProject3
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This test is setting up");
        }

        [Test]
        public async Task Test1()
        {
            await Task.Delay(1500);
            Console.WriteLine("This is finished");
            Assert.Pass();
        }
    }
}