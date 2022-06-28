namespace example004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                if(i % 2 == 0)
                {
                   Console.Write($"{i}");
                }
            }
            
            Console.ReadKey();

        }
    }
}