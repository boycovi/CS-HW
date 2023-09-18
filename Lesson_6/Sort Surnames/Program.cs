Console.WriteLine("Enter Surnames (split with space):");
string input = Console.ReadLine();

string[] surnames = input.Split(' ');

Array.Sort(surnames);

Console.WriteLine("Sorter List:");

foreach (string surname in surnames)
{
    Console.WriteLine(surname);
}