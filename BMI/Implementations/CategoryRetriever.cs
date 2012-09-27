using System;
using System.Linq;
using Bmi.Extensions;
using Bmi.Models;

namespace Bmi.Implementations
{
    public class CategoryRetriever
    {
        public WeightCategory GetWeightCategory(double bmi)
        {
            if (bmi < 0)
            {
                throw new ArgumentException("bmi cannot be less than 0");
            }

            if (bmi >= 0 && bmi < 18.5)
            {
                return WeightCategory.UnderWeight;
            }
            else if (bmi >= 28.5 && bmi <= 24.9)
            {
                return WeightCategory.Normal;
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                return WeightCategory.OverWeight;
            }
            else
                return WeightCategory.Obese;
        }

        public string GetWeightCategoryString(double bmi)
        {
            WeightCategory category = GetWeightCategory(bmi);
            return category.GetStringValue();
        }
    }
}
