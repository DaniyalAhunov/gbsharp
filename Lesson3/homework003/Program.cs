namespace example001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                PrintCub(i);
            }
        }
        public static void PrintCub(int n)
        {
            Console.WriteLine(n * n * n);
        }
    }
}
