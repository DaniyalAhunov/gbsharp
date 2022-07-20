//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
namespace Homework002
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(5, 7);
            int m = new Random().Next(3, 4);
            int[,] array = new int[n, m];
            FillArray(array);
            PrintArray(array);
            int[] arraySum = SumLink(array);
            int index = MinNumber(arraySum);
            Console.WriteLine();
            Console.WriteLine($"Наименьшая сумма в строке {index}");
            Console.ReadKey();
        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 5);
                }
            }
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[] SumLink(int[,] array)
        {
            int[] arraySum = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
                arraySum[i] = sum;
            }
            return arraySum;
        }
        
        static int MinNumber(int[] arraySum)
        {

            int n = 1;
            int index = 1;
            int max = arraySum[0];
            for (int i = 1; i < arraySum.Length; i++)
            {
                Console.Write($"{n++}: {arraySum[i]} ");
                if (arraySum[i] < max)
                {
                    index = i;
                    max = arraySum[i];
                }

            }
            return index;
        }
    }
}