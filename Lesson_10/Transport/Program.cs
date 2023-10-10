namespace transp
{
    class Transport
    {
        protected string Name;
        protected int MaxSpeed;
        public Transport(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}\nMaximum Speed: {MaxSpeed}");
        }
    }
    class Car : Transport
    {
        private int DoorCount;
        public Car(string name, int maxSpeed, int doorCount) : base(name, maxSpeed)
        {
            DoorCount = doorCount;
        }
        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"{DoorCount} doors\n");
        }
    }
    class Bicycle : Transport
    {
        private string Type;
        public Bicycle(string name, int maxSpeed, string type) : base(name, maxSpeed)
        {
            Type = type;
        }
        public void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Type: {Type}\n");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Car AudiA8 = new Car("Audi A8", 250, 4);
            Bicycle BMXBigRipper = new Bicycle("BMX CG Big Ripper", 35, "Sports");
            AudiA8.GetInfo();
            BMXBigRipper.GetInfo();
        }
    }
}