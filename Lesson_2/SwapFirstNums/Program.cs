int b = int.Parse(Console.ReadLine());
int d1 = b / 100;
int d2 = (b / 10) % 10;
int d3 = b % 10;
Console.WriteLine(d2*100+d1*10+d3);
Console.ReadKey();