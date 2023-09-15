int[] firstArray = { 1, 2, 3 };
int[] secondArray = { 4, 5, 6 };
Console.WriteLine("First Array:");
foreach (int element in firstArray)
    Console.Write(element + " ");
Console.WriteLine();

Console.WriteLine("Second Array:");
foreach (int element in secondArray)
    Console.Write(element + " ");
Console.WriteLine();

int[] combinedArray = CombineArrays(firstArray, secondArray);

Console.WriteLine("Combined Array:");

foreach (int element in combinedArray)
    Console.Write(element+" ");
Console.ReadKey();
static int[] CombineArrays(int[] array1, int[] array2)
{
    int combinedLength = array1.Length + array2.Length;
    int[] combinedArray = new int[combinedLength];

    Array.Copy(array1, combinedArray, array1.Length);
    Array.Copy(array2, 0, combinedArray, array1.Length, array2.Length);

    return combinedArray;
}