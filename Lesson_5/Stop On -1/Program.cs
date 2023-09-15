int[] myArray = { 2, 4, 8, 16, -1, 32,64 };

Console.WriteLine("Елементи масиву до першого -1:");
foreach (int element in myArray)
{
    Console.Write(element+" ");
    if (element == -1)
        break;
}
Console.ReadKey();