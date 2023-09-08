using System.Runtime.InteropServices;

while (true)
{
    Console.WriteLine("Enter two numbers:");

    var num1 = Console.ReadLine();
    num1 = int.TryParse(num1, out int n1) ? "" : "false";
    if (num1 == "false")
    {
        Console.WriteLine("Wrong Input\n");
        continue;
    }

    var num2 = Console.ReadLine();
    num2 = int.TryParse(num2, out int n2) ? "" : "false";
    if (num2 == "false")
    {
        Console.WriteLine("Wrong Input\n");
        continue;
    }
    Compare(n1,n2);

    Console.WriteLine("Do you want to exit?: (y/n)");
    string exit = Console.ReadLine();
    if (exit == "y") Environment.Exit(1);
    Console.WriteLine();

    static void Compare(int num1, int num2)
    {
        if (num1 == num2) Console.WriteLine("Numbers are equal\n");
        else if (num1 > num2) Console.WriteLine($"Number {num1} is greater than number {num2}\n");
        else Console.WriteLine($"Number {num2} is greater than number {num1}\n");

    }
}