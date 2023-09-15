using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_To_Array_Beggining
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int numToAdd = random.Next(1, 101);
            int[] array = new int[5];
            Console.WriteLine(numToAdd);
            FillArrayWithRandomNumbers(array);
            PrintArray(array);
            AddElementToBeginning(array, numToAdd);
            PrintArray(array);
            Console.ReadKey();
        }

        static void FillArrayWithRandomNumbers(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
            }
        }

        static void AddElementToBeginning(int[] array, int element)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = array[i];
            }

            array[0] = element;
        }

        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
