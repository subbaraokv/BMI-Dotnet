using System;
using System.Linq;
using Bmi.Interfaces;
using Bmi.Models;

namespace Bmi.Implementations
{
    public class BmiCalculator : IBmiCalculator
    {
        private readonly FormulaType formulaType;

        public BmiCalculator()
            : this(FormulaType.Imperial)
        {

        }

        public BmiCalculator(FormulaType formulaType)
        {
            this.formulaType = formulaType;
        }

        public double Calculate(double mass, double height)
        {
            double bmi = (mass / Math.Pow(height, 2));

            if (this.formulaType == FormulaType.Imperial)
            {
                bmi = bmi * Constants.BmiMultiplicationFactor;
            }
            

            bmi = Math.Round(bmi, 1);
            return bmi;
         
        }
    }
}
