using Classes.Interfaces;

namespace Classes.Classes.Shape
{
    public class Rectangle : Polygon, I2DShapes
    {
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }
        public double Length { set; get; }
        public override double Area()
        {
            return Length * Width;
        }

        public double Perimeter()
        {
            return 2 * Length + 2 * Width;
        }
        public override string GetShapeName()
        {
            return base.GetShapeName();
        }
    }
}
