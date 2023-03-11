using System;
using System.Linq;

namespace AreaCalculator
{
    public class Triangle : Shape
    {
        public Triangle()
        {
            NecessaryAmountParamForCalcArea = 3;
        }

        
        public override double CalculateArea(params double[] values)
        {
            base.CalculateArea(values);
            double a = values[0];
            double b = values[1];
            double c = values[2];
            if (TriangleIsExist(a, b, c))
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            throw new ArgumentException("Triangle is not exist");

        }
        private bool TriangleIsExist(double a,double b, double c) 
        {
            if (a + b < c || a + c < b || b + c < a)
                return false;
            return true;
        }

    }
}