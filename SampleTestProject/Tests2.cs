using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTestProject
{
    [Category("SampleTest2")]
    class Tests2
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
        public void PassingMathTest()
        {

            Assert.That(5 + 10 == 15, "This will pass");
        }

        [Test]
        public void NotAFailingTest()
        {
            Assert.That(5 + 10 == 15, "This will pass");
        }

        
        [Test]
        public void NotAFailingTest22()
        {
            Assert.That(5 + 10 == 15, "This will pass");
        }
    }
}
