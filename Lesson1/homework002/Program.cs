namespace example002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2ое целое число ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3тье целое число ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number2<number1 && number1>number3)
            {
                Console.WriteLine($"Наибольшее число {number1}");
            }
            if (number1<number2 && number2>number3)
            {
                Console.WriteLine($"Наибольшее число {number2}");
            }
            else 
            {
                Console.WriteLine($"Наибольшее число {number3}");
            }
            Console.ReadKey();
        }
    }
}