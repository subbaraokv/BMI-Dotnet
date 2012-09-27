using System;
using System.Linq;
using Bmi.Models;

namespace Bmi.Interfaces
{
    interface IBmiCalculator
    {
        double CalculateWeight(double mass, double height);
        BmiResult CalculateResult(double mass, double height);
    }
}
