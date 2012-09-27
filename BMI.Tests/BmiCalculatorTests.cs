using System;
using System.Linq;
using Xunit;

namespace Bmi.Tests
{
    public class BmiCalculatorTests
    {
        [Fact]
        public void BasicTest()
        {
            int i = 10;
            int j = 20;

            Assert.Equal(30, i + j);
        }
    }
}
