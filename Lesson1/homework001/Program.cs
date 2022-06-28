namespace example001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2ое целое число ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine($"Число {number1} больше {number2} ");
            }
            if(number1 == number2)  
            {
                Console.WriteLine($"Число {number1} равно числу {number2} ");
            }
            else    
            {
               Console.WriteLine($"Число {number2} больше {number1} "); 
            }
            Console.Read();
           
        }
       
    }
}