namespace homework001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое 3х значное число ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            if (numbers > 99 & numbers<1000)
            {
                string number = numbers.ToString();
                Console.WriteLine($" 2я цивра в вашем числе {number[1]} "); 
            }
            else
            {
                Console.WriteLine($"Ваше число не 3х значное {numbers} ");
            }
           Console.ReadKey();
        }
    }
}