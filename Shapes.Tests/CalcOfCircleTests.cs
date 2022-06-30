using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shapes.Tests
{
    [TestClass]
    public class CalcOfCircleTests
    {
        [TestMethod]
        public void CalcOfSquareCircle_Tests()
        {
            double radius = 10;
            double expected = 314.1592653589793;

            CalcOfCircle circle = new CalcOfCircle(radius);
            var actual = circle.CalcOfSquare();

            Assert.AreEqual(expected, actual);
        }
    }
}