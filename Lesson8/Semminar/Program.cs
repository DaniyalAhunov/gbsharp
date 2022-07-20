﻿// 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
namespace Seminar8
{
    class Program
    {
        static void Main(string[] args)
        {
                int n = new Random().Next(3,7);
                int m = new Random().Next(3,7);
                int[,] array = new int[n,m];
                int[,] array2 = new int[n,m];
                FillArray(array);
                Console.WriteLine("Начальный Массив");
                PrintArray(array);
                if(m == n)   
                {
                    ReverseArray(array, array2);
                    Console.WriteLine("Развернутый массив: ");
                    PrintArray(array2);
                }
                else
                {
                    Console.WriteLine("Не возможно заменить строки столбцами");
                }
        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                        array[i,j] = new Random().Next(0,10);
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
        static void ReverseArray(int[,] array, int[,]array2)
        {
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    array2[j,i]= array[i,j];
                }
            }
        }
    }
}

// 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2
// namespace Seminar8
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int n = new Random().Next(3,7);
//             int m = new Random().Next(3,7);
//             int[,] array = new int[m,n];
//             FillArray(array);
//             Console.WriteLine($"Изначальный массив:  ");
//             PrintArray(array);
//             Console.WriteLine("Перевернутый массив: ");
//             ReplacLine(array);
//             PrintArray(array);
//         }
//         static void FillArray(int[,] array)
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1);j++)
//                 {
//                     array[i,j] = new Random().Next(0, 10);
//                 }
//             }
//         }
//         static void ReplacLine(int[,] array)
//         {
//             int lineEnd = array.GetLength(0) - 1;
//             for (int i = 0; i < 1; i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     int number = array[i,j];
//                     array[i,j] = array[lineEnd,j];
//                     array[lineEnd,j] = number;
//                 }
//             }

//         }
//         static void PrintArray(int[,] array)
//         {
//             for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1);j++)
//                 {
//                     Console.Write(array[i,j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }
