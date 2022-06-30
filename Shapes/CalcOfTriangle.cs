namespace Shapes
{
    public class CalcOfTriangle : Shape
    {
        private double _sideA, _sideB, _sideC;

        public CalcOfTriangle(double sideA, double sideB, double sideC)
        {
            if (((sideA + sideB) > sideC) && 
                ((sideB + sideC) > sideA) && 
                ((sideA + sideC) > sideB))
            {
                _sideA = sideA;
                _sideB = sideB;
                _sideC = sideC;
            }
            else { _sideA = _sideB = _sideC = 1; }
        }
        public override double CalcOfSquare()
        {
            var p = (_sideA + _sideB + _sideC) / 2;
            var square = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            return square;
        }
        public bool IsRectangular()
        {
            if (Math.Pow(_sideC, 2) == 
                Math.Pow(_sideA, 2) + 
                Math.Pow(_sideB, 2)) 
                return true;
            return false;
        }
    }
}
