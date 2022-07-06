//Напишите программу, которая задаёт случайный массив случайного размера (от 5 до 10) элементов 
//(значение элементов от 1 до 40) и выводит на экран массив квадратов этих чисел.
namespace homework002
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = new Random().Next(5, 11);
            int[] arrayNumber = new int[count];
            RandomAndPrint(arrayNumber);
            Console.WriteLine();
            Console.WriteLine("Массив Квадратов: ");
            PrintArrayDouble(arrayNumber);
            Console.ReadKey();
        }
        public static void RandomAndPrint(int[] array)
        {
            int count = array.Length;
            for (int i = 0; i < count;i++)    
            {
                int number = new Random().Next(0, 41);
                array[i] = number;
                Console.Write($"{array[i]} ");
            }
        }  
        public static void PrintArrayDouble(int[] array)
        {

            int count = array.Length;
            for (int i = 0; i < count;i++)    
            {
                Console.Write($"{array[i] * array[i]} ");
            }
        } 
        
    }
}