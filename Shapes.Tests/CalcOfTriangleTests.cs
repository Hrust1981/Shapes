using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shapes.Tests
{
    [TestClass]
    public class CalcOfTriangleTests
    {
        CalcOfTriangle triangle;

        [TestInitialize]
        public void Setup()
        {
            double a = 3, b = 4, c = 5;
            triangle = new CalcOfTriangle(a, b, c);
        }

        [TestCleanup]
        public void Clean() { }

        [TestMethod]
        public void CalcOfSquareTriangle_Test()
        {
            double expected = 6;
            
            var actual = triangle.CalcOfSquare();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsRectangular_Test()
        {
            bool expected = true;

            var actual = triangle.IsRectangular();

            Assert.AreEqual(expected, actual);
        }
    }
}