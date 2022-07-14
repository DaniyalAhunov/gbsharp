// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
namespace homework001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел: ");
            string number = Console.ReadLine().ToString();
            int moreNull = NumberMoreNull(number);
            Console.WriteLine($"Введенных чисел больше 0: {moreNull} " );

            
        }

        static int NumberMoreNull ( string number )
        {
            string[] numbers = number.Split(' ');
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Convert.ToInt32(numbers[i]) > 0)
                {
                    count++;
                }
            }
            return count;

        }
    }
}