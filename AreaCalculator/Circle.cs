using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle:Shape
    {
        public Circle() 
        {
            NecessaryAmountParamForCalcArea = 1;
        }
        public override double CalculateArea(params double[] values)
        {
            base.CalculateArea(values);
            return values[0] * values[0] * Math.PI;
        }
    }
}
