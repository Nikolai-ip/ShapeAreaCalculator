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
    public class CalculatorTriangleAreaTest
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            double area = ShapeAreaCalculator.CalculateArea(5,5,4);
            Assert.AreEqual(9.165, area, 0.001);
        }
        [TestMethod]
        public void NegativeValueTest()
        {
            try
            {
                double area = ShapeAreaCalculator.CalculateArea(5, -5, 4);
                Assert.Fail();
            }
            catch (Exception) { }
        }
        [TestMethod]
        public void NotExistTringleTest()
        {
            try
            {
                double area = ShapeAreaCalculator.CalculateArea(1, 2, 4);
                Assert.Fail();
            }
            catch (Exception) { }
        }
        [TestMethod]
        public void NotExistTringleLimitValuesTest()
        {
            try
            {
                double area = ShapeAreaCalculator.CalculateArea(1, 3, 4);
                Assert.Fail();
            }
            catch (Exception) { }
        }
        [TestMethod]
        public void OverflowValueTest()
        {
            try
            {
                double area = ShapeAreaCalculator.CalculateArea(1,1,10000000000000000000000000000000000000000000000000000000000000000.0);
                Assert.Fail();
            }
            catch (Exception) { }
        }
        [TestMethod]
        public void ZeroValueTest()
        {
            double area = ShapeAreaCalculator.CalculateArea(0,0,0);
            Assert.AreEqual(0, area);
        }
    }
}
