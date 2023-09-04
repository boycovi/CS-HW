Console.Write("Enter a number to reverse: ");
int num = int.Parse(Console.ReadLine());
int d1 = num / 100;
int d2 = (num / 10) % 10;
int d3 = num % 10;
Console.WriteLine(d3 * 100 + d2 * 10 + d1);
Console.ReadKey();