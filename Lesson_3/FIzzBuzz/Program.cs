while (true)
{
    Console.WriteLine("Enter a number between 1 and 100: ");
    int n = int.Parse(Console.ReadLine());
    if (n % 15 == 0) Console.WriteLine("FizzBuzz");
    else if (n % 5 == 0) Console.WriteLine("Buzz");
    else if (n % 3 == 0) Console.WriteLine("Fizz");
}