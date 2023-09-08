while (true)
{
    Console.WriteLine("Enter an index of the month: \n");
    var num = Console.ReadLine();
    num = int.TryParse(num, out int n) ? "" : "false";
    if (num == "false")
    {
        Console.WriteLine("Wrong Input\n");
        continue;
    }
    Console.WriteLine();
    switch (n)
    {

        case 1:case 2:case 12: Console.WriteLine("Winter");break;
        case 3:case 4:case 5: Console.WriteLine("Spring");break;
        case 6:case 7:case 8: Console.WriteLine("Summer");break;
        case 9:case 10:case 11: Console.WriteLine("Autumn");break;
        default: Console.WriteLine("This month doesn't exist\n"); break;
    }
    Console.WriteLine("Do you want to exit?: (y/n)");
    string exit = Console.ReadLine();
    if (exit == "y") Environment.Exit(1);
    Console.WriteLine();
}