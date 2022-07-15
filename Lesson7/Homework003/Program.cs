// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int line = new Random().Next(3,7);
            int column = new Random().Next(3,7);
            int[,] array = new int[line, column];
            FillArray(array);
            PrintArray(array);
            MeanColumn(array);
        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    array[i,j] = new Random().Next(0,100);
                }
            }
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void MeanColumn(int[,] array)
        {
            double count = array.GetLength(1);
            Console.Write("Стредне арифметическое каждого столбца: ");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    sum = sum + array[j,i];
                }
                sum = sum/count;
                Console.Write($"{ Math.Round(sum, 1)}; ");
            }
        }

    }
}