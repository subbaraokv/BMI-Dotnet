using Bmi.Implementations;
using System;
using System.Linq;
using Bmi.Models;
using Xunit;

namespace Bmi.Tests
{
    public class BmiCalculatorTests
    {
        [Fact]
        public void Calculat_Bmi_In_Imperial_Mode()
        {
            double weight = 190;
            double height = 72;

            var calculator = new BmiCalculator();

            Assert.Equal(25.8, calculator.Calculate(weight, height));
        }

        [Fact]
        public void Calculat_Bmi_In_Metric_Mode()
        {
            double weight = 85;
            double height = 1.82;

            var calculator = new BmiCalculator(FormulaType.Metric);

            Assert.Equal(25.7, calculator.Calculate(weight, height));
        }
    }
}
