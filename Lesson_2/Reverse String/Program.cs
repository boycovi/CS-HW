Console.Write("Enter a number to reverse: ");
int num = int.Parse(Console.ReadLine());
int rNum = 0, r;
while (num > 0)
{
    r = num % 10;
    rNum = (rNum * 10) + r;
    num /= 10;
}
Console.WriteLine(rNum);
Console.ReadKey();