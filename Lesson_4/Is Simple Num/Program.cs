Random random = new Random();
int genNum = random.Next(2, 1000);
Console.WriteLine(genNum);

static bool CheckSimple(int num)
{
    for (int i = 2; i < num; i++)
    {
        if (num % i == 0)
        {
            Console.WriteLine("Not simple");
            return false;
        }
    }
    Console.WriteLine("Simple");
    return true;
}