using Bmi.Implementations;
using Bmi.Models;
using System;
using System.Linq;

namespace Bmi.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightInImperialMode = 190;
            double heightInImperialMode = 72;

            var calculator = new BmiCalculator();

            Console.WriteLine("Bmi in Imperial mode is "+ calculator.CalculateWeight(weightInImperialMode, heightInImperialMode));

            double weightInMetricMode = 85;
            double heightInMetriMode = 1.82;

            var metricCalculator = new BmiCalculator(FormulaType.Metric);

            Console.WriteLine("Bmi in metric mode is " + metricCalculator.CalculateWeight(weightInMetricMode, heightInMetriMode));

            BmiResult bmiResult = calculator.CalculateResult(weightInImperialMode, heightInImperialMode);
            Console.WriteLine("Bmi in Imperial mode is " + bmiResult.Bmi + " Weight category is " + bmiResult.Category);

        }
    }
}
