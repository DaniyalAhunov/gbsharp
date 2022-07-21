// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
namespace Homework003
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = new Random().Next(3, 4);
            // int m = new Random().Next(3, 4);
            // int z = new Random().Next(3, 4);
            int[,,] array = new int[2, 2, 2];
            FillArray(array);
            PrintArray(array);
        }
        static void FillArray(int[,,] array)
        {
            int number = new Random().Next(10, 100);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        array[i, j,k] = number+1; 
                        number++;    
                    }
                }
            }
        }
         static void PrintArray(int[,,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
