namespace dophomework005
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количесво цифр:");
            int i = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine($"Введите целое {i} значное число");
            string number = Console.ReadLine();
            if (int.TryParse(number, out int numbers))
                {
                    int end = int.Parse(number[i -1].ToString());
                    Console.Write("Вы ввели число {0}", numbers);
                    Console.Write($" Последняя цифра {end}");

                }
            else
                {
                    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
                }
            
           
            Console.ReadKey();
        }
    }

}