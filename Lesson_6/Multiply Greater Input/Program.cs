int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
foreach (int i in array)
    Console.Write(i + " ");
int counter = 1;
Console.WriteLine("\nEnter a number: ");

if (int.TryParse(Console.ReadLine(), out int num))
{
    foreach (int i in array)
    {
        if (i > num)
            counter *= i;
    }
}
else
{
    Console.WriteLine("Wrong Input");
    Environment.Exit(0);

}
Console.WriteLine(counter);