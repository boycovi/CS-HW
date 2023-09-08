while (true)
{
    Console.WriteLine("Enter an index of the day of the week: \n");
    var num = Console.ReadLine();
    num = int.TryParse(num, out int n) ? "" : "false";
    if (num == "false")
    {
        Console.WriteLine("Wrong Input\n");
        continue;
    }

    switch (n)
    {
        case 1: Console.WriteLine("Monday\n"); break;
        case 2: Console.WriteLine("Tuesday\n"); break;
        case 3: Console.WriteLine("Wednesday\n"); break;
        case 4: Console.WriteLine("Thursday\n"); break;
        case 5: Console.WriteLine("Friday\n"); break;
        case 6: Console.WriteLine("Saturday\n"); break;
        case 7: Console.WriteLine("Sunday\n"); break;
        default: Console.WriteLine("This day doesn't exist\n"); break;
    }

    Console.WriteLine("Do you want to exit?: (y/n)");
    string exit = Console.ReadLine();
    if (exit == "y") Environment.Exit(1);
    Console.WriteLine();
}