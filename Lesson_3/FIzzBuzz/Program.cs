while (true)
{
    Console.WriteLine("Enter a number between 1 and 100: ");
    var n = Console.ReadLine();
    int.TryParse(n, out int num);
    if (num <= 0)
    {
        Console.WriteLine("Wrong Input");
        continue;
    }
    if (num % 15 == 0) Console.WriteLine("FizzBuzz");
    else if (num % 5 == 0) Console.WriteLine("Buzz");
    else if (num % 3 == 0) Console.WriteLine("Fizz");
    Console.WriteLine("Do you want to exit?: (y/n)");
    string exit = Console.ReadLine();
    if (exit == "y") Environment.Exit(1);
    Console.WriteLine();
}