while (true)
{
    Console.WriteLine("Enter a number: ");
    var num = Console.ReadLine();
    num = int.TryParse(num, out int n) ? "" : "false";
    if (num == "false")
    {
        Console.WriteLine("Wrong Input\n");
        continue;
    }
    Console.WriteLine(n % 2 == 0 ? $"Number {n} is even\n" : $"Number {n} is odd\n");
    Console.WriteLine("Do you want to exit?: (y/n)");
    string exit = Console.ReadLine();
    if (exit == "y") Environment.Exit(1);
    Console.WriteLine();
}