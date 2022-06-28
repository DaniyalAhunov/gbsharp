namespace homework001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое 3х значное число ");
            string number = Console.ReadLine().ToString();
            Console.WriteLine($" 2я цивра в вашем числе {number[1]} ");
        }
    }
}