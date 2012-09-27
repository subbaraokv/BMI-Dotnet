using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi.Interfaces
{
    interface IBmiCalculator
    {
        double Calculate(double mass,double height);
    }
}
