//Задайте значения M и N. Напишите программу, которая выведет все натуральные
//числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""
namespace Homework001
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n = 0;
            try
            {
                Console.WriteLine("Введите значение начала промежутка: ");
                 m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение конца промежутка: ");
                 n = Convert.ToInt32(Console.ReadLine());
               
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный Формат. Введите цифры");
            }
            PrintNumbers(m, n);

        }
        static void PrintNumbers(int m, int n)
        {
            if (m > n)
            {
                int revers = m;
                m = n;
                n = revers;
            }
            Console.WriteLine("Ваши натуральные числа: ");
            for (int i = m; i <= n; i++) 
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}