//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
namespace homework001
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = new Random().Next(5,11);
            int[] arrayNumber = new int[count];
            Console.WriteLine("Первоночальный массив: ");
            FillArray(arrayNumber);
            Console.WriteLine();
            int evenNumber = ChetNumber(arrayNumber);
            Console.WriteLine($"Количесво четных элементов: {evenNumber}");
            Console.ReadKey();

        }
        //Заполнение и печать Массива 
        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length;i++)
            {
                int number = new Random().Next(100,1000);
                array[i] = number;
                Console.Write($"{array[i]} ");
            }
        }
        //Поиск в массиве количества четных элементов
        static int ChetNumber(int[] array)
        {
            int number = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] % 2 == 0)
                {
                    number++;
                    
                }
               
            }
            return number;
        }
    }
}
