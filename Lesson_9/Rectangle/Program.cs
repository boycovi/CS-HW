namespace Rect
{
    public class Rectangle
    {
        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5.0, 3.0);
            double area = rectangle.AreaCalculator();
            double perimeter = rectangle.PerimeterCalculator();

            Console.WriteLine("Rectangle Area: " + area);
            Console.WriteLine("Rectangle Perimeter: " + perimeter);
        }
    }
}
