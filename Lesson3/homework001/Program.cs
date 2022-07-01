namespace example001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 5ти значное число ");
            string number = Console.ReadLine().ToString();
            if (number[0]==number[4])
            {
                if (number[1] == number[3])
                {
                    Console.WriteLine("Да число является палиндромом");
                }
                else
                {
                    Console.WriteLine("Нет число не является палиндромом");
                }
            }
            else
            {
                Console.WriteLine("Нет число не является палиндромом");
            }
            Console.ReadKey();
        }
        
    }
}