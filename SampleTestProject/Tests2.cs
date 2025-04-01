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
    }
}
