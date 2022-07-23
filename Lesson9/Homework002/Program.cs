//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
namespace Homework003
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
            int sum = LupSum(m, n);
            Console.WriteLine($"Сумма числе из вашего промежутка равна {sum}");
        }
        static int LupSum(int m, int n)
        {
            int sum = 0;
            if (m > n)
            {
                int revers = m;
                m = n;
                n = revers;
            }
            for (int i = m; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}