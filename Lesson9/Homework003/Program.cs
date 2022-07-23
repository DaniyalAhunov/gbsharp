//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 29
namespace Homework003
{
    class Program
    {
        static void Main(string[] args)
        {
            uint m = 0;
            uint n = 0;
            try
            {
                Console.WriteLine("Введите первое значение : ");
                n = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Введите  второе значение : ");
                m = Convert.ToUInt32(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный Формат. Введите исключительно положительные цифры");
            }
            Console.WriteLine(A(m, n));
        }
        static uint A(uint n, uint m)
        {
            if (n == 0)
            {
                return m + 1;
            }
            else
            {
                if ((n != 0) && (m == 0))
                {
                    return A(n - 1, 1);
                }
                else
                {
                    return A(n - 1, A(n, m - 1));
                }

            }
        }
    }
}