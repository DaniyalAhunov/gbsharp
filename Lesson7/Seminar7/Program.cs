// 1. Задайте двумерный массив размера m на n, каждый элемент в 
//массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
        {
            Console.WriteLine("Введите количество столбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[m,n];
            FillArray(array, m, n);
            PrintArray(array, m, n);
        }
        static void FillArray(int[,] array, int m, int n)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    array[i,j] = i + j;
                }
            }
        }
        static void PrintArray(int[,] array, int m, int n)
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
        }
    }
}