using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorTest
{
    [TestClass]
    public class ShapeAreaCalculatorTest
    {
        [TestMethod]
        public void PassNotExistShapeParams()
        {
            try
            {
                double area = ShapeAreaCalculator.CalculateArea(1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1);
                Assert.Fail();
            }
            catch (Exception) { }
        }
    }
}
