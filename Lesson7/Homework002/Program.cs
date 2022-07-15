﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
//элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = new Random().Next(5,7);
            int column = new Random().Next(5,7);
            int[,] array = new int[line, column];
            Console.WriteLine("Введите номер строки начинается с 1 ");
            int positionList = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine("Введите номер cтобца начинается с 1 ");
            int positionColumn = Convert.ToInt32(Console.ReadLine())-1;
            FillArray(array);
            PrintArray(array);
            bool result = PositionReturn(array, positionList, positionColumn);
            if (result == false)
            {
                Console.WriteLine("такого элемента в массиве нет");
            }
            else
            {
                Console.WriteLine($"Число в позиции лежит:{array[positionList, positionColumn]}");
            }
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
            Console.WriteLine("Ваш массив ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1);j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static bool PositionReturn(int[,] array, int posLine, int posColumn)
        {
            bool result = false;
            if (posLine < array.GetLength(0) && posColumn < array.GetLength(1))
            {
                result = true;
                return result;
            }
            return result;
        }
    }
}