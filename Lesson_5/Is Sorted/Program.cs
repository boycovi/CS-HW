int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write("Enter number №" + (i + 1) + ": ");
    if (int.TryParse(Console.ReadLine(), out int num))
    {
        numbers[i] = num;
    }
    else
    {
        Console.WriteLine("Invalid Input");
        i--;
    }
}

if (IsSorted(numbers, ascending: true))
{
    Console.WriteLine("Numbers are sorted in ascending order");
}
else if (IsSorted(numbers, ascending: false))
{
    Console.WriteLine("Numbers are storted in descending order");
}
else
{
    Console.WriteLine("Numbers are unsorted");
}
Console.ReadKey();
static bool IsSorted(int[] array, bool ascending)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int comparisonResult = ascending ? array[i].CompareTo(array[i + 1]) : array[i + 1].CompareTo(array[i]);
        if (comparisonResult > 0)
        {
            return false;
        }
    }
    return true;
}