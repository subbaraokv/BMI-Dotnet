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
        public void Calculate_Bmi_In_Imperial_Mode()
        {
            double weight = 190;
            double height = 72;

            var calculator = new BmiCalculator();

            Assert.Equal(25.8, calculator.CalculateWeight(weight, height));
        }

        [Fact]
        public void Calculate_Bmi_In_Metric_Mode()
        {
            double weight = 85;
            double height = 1.82;

            var calculator = new BmiCalculator(FormulaType.Metric, new CategoryRetriever());

            Assert.Equal(25.7, calculator.CalculateWeight(weight, height));
        }

        [Fact]
        public void Calculate_BmiResult_In_Imperial_Mode()
        {
            double weight = 190;
            double height = 72;

            var calculator = new BmiCalculator();

            BmiResult actual = calculator.CalculateResult(weight, height);

            double bmiResult = 25.8;
            string category = "Over weight";
            var expected = new BmiResult(bmiResult, category);

            Assert.NotNull(actual);
            Assert.Equal(expected.Bmi, actual.Bmi);
            Assert.Equal(expected.Category, actual.Category);
           
        }

        [Fact]
        public void Calculate_BmiResult_In_Metric_Mode()
        {
            double weight = 85;
            double height = 1.82;

            var calculator = new BmiCalculator(FormulaType.Metric, new CategoryRetriever());

            BmiResult actual = calculator.CalculateResult(weight, height);

            double bmiResult = 25.7;
            string category = "Over weight";
            var expected = new BmiResult(bmiResult, category);

            Assert.NotNull(actual);
            Assert.Equal(expected.Bmi, actual.Bmi);
            Assert.Equal(expected.Category, actual.Category);
        }
    }
}
