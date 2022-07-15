// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
namespace Seminar7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество столбцов");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество строк");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,] array = new double[m, n];
            FillArray(array, m, n);
            PrintArray(array, m, n);
        }
        static void FillArray(double[,] array, int m, int n)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Random rnd = new Random();
                    array[i, j] = 20.0*rnd.Next()/2147483648-10.0; //еле нашел такую формулу 
                }
                
            }

        }
        static void PrintArray(double[,] array, int m, int n)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    double number = array[i, j];
                    Console.Write($"{ Math.Round(number, 1)} ");
                }
                Console.WriteLine();
            }
        }
    }
}