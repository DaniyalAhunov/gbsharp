//Задача 58: Задайте две матрицы. Напишите программу, которая выведет матрицу произведения элементов двух предыдущих матриц.
namespace Homework003
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3, 7);
            int m = new Random().Next(3, 7);
            int[,] array = new int[n, m];
            int[,] array2 = new int[n, m];
            Console.WriteLine("Первый массив:");
            FillArray(array);
            PrintArray(array);
            Console.WriteLine("второй массив:");
            FillArray(array2);
            PrintArray(array2);
            Console.WriteLine("Произведение двух массивов: ");
            int[,]factorArray = FactorArray(array, array2, n, m);
            PrintArray(factorArray);
            Console.ReadKey();

        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 10);
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
        static int[,] FactorArray(int[,] array, int[,] array2, int n ,int m)
        {
            int[,] factorArray = new int[n, m];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    factorArray[i, j] = array[i, j] * array2[i, j];
                }
            }
            return factorArray;
        }
    }
}