using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculatorTest
{
    [TestClass]
    public class CalculatorCircleAreaTest
    {
        [TestMethod]
        public void CalculateAreaTest()
        {
            double area = ShapeAreaCalculator.CalculateArea(5);
            Assert.AreEqual(78.53982, area, 0.00001);
        }
        [TestMethod]
        public void NegativeValueTest()
        {
            try
            {
                double area = ShapeAreaCalculator.CalculateArea(-5);
                Assert.Fail();
            }
            catch (Exception) { }
        }
        [TestMethod]
        public void OverflowValueTest() 
        {
            try
            {
                double area = ShapeAreaCalculator.CalculateArea(10000000000000000000000000000000000000000000000000000000000000000.0);
                Assert.Fail();
            }
            catch (Exception) { }
        }
        [TestMethod]
        public void ZeroValueTest()
        {
            double area = ShapeAreaCalculator.CalculateArea(0);
            Assert.AreEqual(0, area);
        }
    }
}
