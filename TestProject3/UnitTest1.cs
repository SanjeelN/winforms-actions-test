using System.Threading.Tasks;

namespace TestProject3
{
    public class Tests
    {
        [OneTimeSetUp]
        public void GlobalSetup()
        {
            Console.WriteLine("Global test setup - could be database connection");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Individual test setup - could be test data preparation");
        }

        [Test]
        public void SampleIntegrationTest()
        {
            // Arrange
            Console.WriteLine("Setting up test data...");

            // Act
            Console.WriteLine("Performing test action...");
            System.Threading.Thread.Sleep(100); // Simulate some work

            // Assert
            Console.WriteLine("Verifying results...");
            Assert.Pass("Integration test completed successfully");
        }

        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine("Cleaning up test resources");
        }

        [OneTimeTearDown]
        public void GlobalCleanup()
        {
            Console.WriteLine("Global cleanup - could be closing database connections");
        }
    }
}