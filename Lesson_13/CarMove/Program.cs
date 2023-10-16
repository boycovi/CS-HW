namespace CarMove
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine($"X: {myCar.Position.X}, Y: {myCar.Position.Y}");

            car.Move(10, 20);
            Console.WriteLine($"X: {myCar.Position.X}, Y: {myCar.Position.Y}");

            car.StartEngine();
            Console.WriteLine($"X: {myCar.Position.X}, Y: {myCar.Position.Y}");

            car.StopEngine();
        }
    }
}