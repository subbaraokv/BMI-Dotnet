using System;
using System.Linq;
using Bmi.Interfaces;
using Bmi.Models;

namespace Bmi.Implementations
{
    public class BmiCalculator : IBmiCalculator
    {
        private readonly FormulaType formulaType;

        private readonly CategoryRetriever categoryRetriever;

        public BmiCalculator() : this(FormulaType.Imperial, new CategoryRetriever())
        {

        }

        public BmiCalculator(FormulaType formulaType, CategoryRetriever categoryRetriever)
        {
            this.categoryRetriever = categoryRetriever;
            this.formulaType = formulaType;
        }

        public double CalculateWeight(double mass, double height)
        {
            double bmi = (mass / Math.Pow(height, 2));

            if (this.formulaType == FormulaType.Imperial)
            {
                bmi = bmi * Constants.BmiMultiplicationFactor;
            }
            

            bmi = Math.Round(bmi, 1);
            return bmi;
        }

        public BmiResult CalculateResult(double mass, double height)
        {
            double bmi = CalculateWeight(mass, height);
            string category = categoryRetriever.GetWeightCategoryString(bmi);

            BmiResult bmiResult = new BmiResult()
                                        {
                                            Bmi = bmi,
                                            Category = category
                                        };
            return bmiResult;
        }
    }
}
