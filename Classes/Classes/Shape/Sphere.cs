using Classes.Interfaces;

namespace Classes.Classes.Shape
{
    public class Sphere : ICircularShapes, I3DShapes

    {
        public double Radius { get; set; }
        public Sphere(double r)
        {
            Radius = r;
        }
        public double Circumference()
        {
            return 4 * Math.PI * Math.Pow(Radius, 3);
        }

        public double Volume()
        {
            return 4 / 3 * Math.PI * Radius;
        }
    }
}
