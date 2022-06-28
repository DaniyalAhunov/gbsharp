namespace homework002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            //int numbers = Convert.ToInt32(Console.ReadLine());
            string number = Console.ReadLine().ToString();
            if(Convert.ToInt32(number) > 99)
            {
                Console.WriteLine($" 3я цивра в вашем числе {number[2]} ");
            }
            else
            {
                Console.WriteLine("В вашем числе меньше 3х цифр"); 
            }
           Console.ReadKey();
        }
    }
}