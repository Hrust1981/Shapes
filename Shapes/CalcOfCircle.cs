
namespace Shapes
{
    public class CalcOfCircle : Shape
    {
        private double _radius;
        public CalcOfCircle(double radius)
        {
            _radius = radius;
        }

        public override double CalcOfSquare() => Math.PI * Math.Pow(_radius, 2);
    }
}
