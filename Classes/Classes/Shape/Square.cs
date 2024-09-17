namespace Classes.Classes.Shape
{
    public class Square : Polygon
    {
        public Square(double width)
        {
            Width = width;
        }
        public override double Area()
        {
            //Math.Pow(Width, 2); 
            return Width * Width;
        }
    }
}
