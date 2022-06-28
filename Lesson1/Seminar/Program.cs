namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2 целое число: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int dubl = number2*number2;
            if (number1 == dubl)
            {
                Console.WriteLine($"Число {number1} является квадратом {number2}");
            }
            else
            {
                Console.WriteLine($"Число {number1} не является квадратом {number2}");
            }
        }
    }
}
// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.