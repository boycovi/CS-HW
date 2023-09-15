int[] myArray = { 1, 2, 3, 4, 5 };

Console.WriteLine("Current Array: " + string.Join(", ", myArray));

Console.Write("Enter an index to remove: ");
if (int.TryParse(Console.ReadLine(), out int position))
{
    if (position >= 0 && position < myArray.Length+1)
    {
        int[] newArray = RemoveElement(myArray, position - 1);
        Console.WriteLine("Current Array " + string.Join(", ", newArray));
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Invalid Number, enter a number between 1 and " + (myArray.Length));
        Console.ReadKey();
    }
}
else
{
    Console.WriteLine("Invalid Input");
    Console.ReadKey();
}
static int[] RemoveElement(int[] array, int position)
{
    int[] newArray = new int[array.Length - 1];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (i != position)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}