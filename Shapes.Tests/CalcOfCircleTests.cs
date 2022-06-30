using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shapes.Tests
{
    [TestClass]
    public class CalcOfCircleTest
    {
        [TestMethod]
        public void CalcOfSquareCircle_Test()
        {
            double radius = 10;
            double expected = 314.15;

            CalcOfCircle circle = new CalcOfCircle(radius);
            var actual = circle.CalcOfSquare();

            Assert.AreEqual(expected, actual, 0.01);
        }
    }
}