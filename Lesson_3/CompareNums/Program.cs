while (true)
{
    Console.WriteLine("Enter two numbers:");
    int num1 = int.Parse(Console.ReadLine());
    int num2 = int.Parse(Console.ReadLine());

    if (num1 == num2) Console.WriteLine("Numbers are equal\n");
    else if (num1 > num2) Console.WriteLine($"Number {num1} is greater than number {num2}\n");
    else Console.WriteLine($"Number {num2} is greater than number {num1}\n");
}