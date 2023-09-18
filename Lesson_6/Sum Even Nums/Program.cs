int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (int i in array)
    Console.Write(i+" ");
int evenSum = 0;
foreach (int n in array)
{
    if (n % 2 == 0)
        evenSum += n;
}
Console.WriteLine("\n"+evenSum);
Console.ReadKey();