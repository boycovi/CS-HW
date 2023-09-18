int[,] matrix = {
            { 1, -2, 3 },
            { -4, 5, -6 },
            { 7, 8, -9 }
        };

int positiveCount = 0;
int negativeCount = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int element = matrix[i, j];

        if (element > 0)
        {
            positiveCount++;
        }
        else if (element < 0)
        {
            negativeCount++;
        }
    }
}
Console.WriteLine($"positive:{positiveCount}\nnegative:{negativeCount}");
Console.ReadKey();