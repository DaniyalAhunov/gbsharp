// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
namespace Homework001
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3, 7);
            int m = new Random().Next(3, 7);
            int[,] array = new int[n, m];
            int[,] arraySort = new int[n, m];
            FillArray(array);
            Console.WriteLine("Начальный массив: ");
            PrintArray(array);
            SortArray(array,arraySort);
            Console.WriteLine("Сортированый массив: ");
            PrintArray(arraySort);
        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 10);
                }
            }
        }
        static void SortArray(int[,] array,int[,] arrayEnd)
        {
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] array2 = new int[array.GetLength(1)];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array2[j] = array[i, j];
                }
                Array.Sort(array2);
                for (int z = 0; z < arrayEnd.GetLength(1); z++)
                {

                    arrayEnd[i, z] = array2[z];
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
    }
}
