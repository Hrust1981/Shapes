using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shapes.Tests
{
    [TestClass]
    public class CalcOfTriangleTests
    {
        [TestMethod]
        public void CalcOfSquareTriangle_Tests()
        {
            double a = 3, b = 4, c = 5;
            double expected = 6;

            CalcOfTriangle circle = new CalcOfTriangle(a, b, c);
            var actual = circle.CalcOfSquare();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRectangular_Tests()
        {
            double a = 3, b = 4, c = 5;
            bool expected = true;

            CalcOfTriangle circle = new CalcOfTriangle(a, b, c);
            var actual = circle.IsRectangular();

            Assert.AreEqual(expected, actual);
        }
    }
}