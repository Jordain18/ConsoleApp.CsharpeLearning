using Classes.Interfaces;

namespace Classes.Classes.Shape
{
    public class Cuboid : Polygon, I2DShapes, I3DShapes
    {
        public Cuboid(double length, double width, double height)
        {
            Width = width;
            Length = length;
            Height = height;
        }
        public double Length { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return 2 * (Width * Length) + Height * Length + Height * Width;
        }

        public double Perimeter()
        {
            return 4 * (Length + Width + Height);
        }

        public double Volume()
        {
            return Length * Width * Height;
        }
    }
}
