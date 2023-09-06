while (true)
{
    Console.WriteLine("Enter an index of the month: \n");
    int n = int.Parse(Console.ReadLine());
    Console.WriteLine();
    switch (n)
    {

        case 1:case 2:case 12: Console.WriteLine("Winter");break;
        case 3:case 4:case 5: Console.WriteLine("Spring");break;
        case 6:case 7:case 8: Console.WriteLine("Summer");break;
        case 9:case 10:case 11: Console.WriteLine("Autumn");break;
        default: Console.WriteLine("This month doesn't exist\n"); break;
    }
}