namespace seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите целое число ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int ost = number1 % number2 ;
            if (number1 > number2)
            {
                if (ost == 0)
                {
                    Console.WriteLine("Кратно");
                }
                if  (ost != 0)
                {
                    Console.WriteLine($"Не кратно! Остаток: {ost}");
                }
            }
            else
            {
                Console.WriteLine($"Первое число должно быть больше второго");
            }
            Console.ReadKey();
        }
        
    }
}