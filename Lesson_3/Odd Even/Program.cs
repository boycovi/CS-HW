while (true)
{
    Console.WriteLine("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine(num % 2 == 0 ? $"Number {num} is even\n" : $"Number {num} is odd\n");
}