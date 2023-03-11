using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public abstract class Shape
    {
        public int NecessaryAmountParamForCalcArea { get; protected set; }
        public virtual double CalculateArea(params double[] values)
        {
            if (values.Length!=NecessaryAmountParamForCalcArea)
                throw new ArgumentOutOfRangeException();
            if (!values.All(val => val >= 0))
                throw new ArgumentException();
            return 0;
        }
    }
}
