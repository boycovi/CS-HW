namespace Fig
{
    class Figure
    {
        protected double X;
        protected double Y;

        public Figure(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Coordinates: ({X}, {Y})");
        }
    }

    class Circle : Figure
    {
        private double Radius;
        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Radius: {Radius}");
        }
    }

    class Rectangle : Figure
    {
        private double Width;
        private double Height;

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Width: {Width}\nHeight: {Height}");
        }
    }

    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(3.0, 4.0, 5.0);

            Console.WriteLine("Circle Info:");
            circle.GetInfo();

            Rectangle rectangle = new Rectangle(1.0, 2.0, 6.0, 8.0);

            Console.WriteLine("\nRectangle info:");
            rectangle.GetInfo();
        }
    }
}