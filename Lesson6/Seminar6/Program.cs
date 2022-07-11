//1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
//2. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
namespace seminar6
{
    class Program
    {
        static void Main(string[] args)
        {
          int count = new Random().Next(5,11);
          int[] array = new int[count]; 
          FillArray(array);
          PrintArray(array);
          ReverseArray(array);
          PrintArray(array);
        }
        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0, 99);
            }

        }
        public static void ReverseArray(int[] array)
        {
            for (int i = 0; i < array.Length/2;i++)
            {
                int x = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = x;
            }
        }
        public static void PrintArray(int[] array)
        {
            Console.Write("[ ");
            for (int i = 0; i<array.Length;i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("]");
        }
    }
}