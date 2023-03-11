using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class ShapeAreaCalculator
    {
        static List<Shape> _shapes = new List<Shape>() { new Circle(), new Triangle() };
        public static double CalculateArea(params double[] values)
        {
            double? area = _shapes
                .FirstOrDefault(shape => shape.NecessaryAmountParamForCalcArea == values.Length)
                .CalculateArea(values);
            if (area == null)
                throw new ArgumentException("There is no such figure for which the required amount for calculating the area is equal to the number of given values");
            return (double) area;       
        }
    }
}
