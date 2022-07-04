//1. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4  -> 24
//5  -> 120

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
namespace seminar4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество символов массива");   
            int count = Convert.ToInt32(Console.ReadLine());
            int[] arrayNumber = new int[count];
            Random(arrayNumber);
            PrintArray(arrayNumber);
            Console.ReadKey();
                
        
        }
        public static void Random(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count;i++)    
            {
                int number = new Random().Next(0, 2);
                array[i] = number;
            }
        }

        public static void PrintArray(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count;i++)    
            {
                Console.Write($"{array[i]} ");
            }
        }


    }
}