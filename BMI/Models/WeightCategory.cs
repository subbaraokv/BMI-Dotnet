using System;
using System.Linq;

namespace Bmi.Models
{
    public enum WeightCategory
    {
        [StringValue("Under weight")]
        UnderWeight,
        [StringValue("Normal weight")]
        Normal,
        [StringValue("Over weight")]
        OverWeight,
        [StringValue("Obese")]
        Obese
    }
}
