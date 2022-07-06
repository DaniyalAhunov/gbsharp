//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
namespace homework001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число(Степень)");
            int step = Convert.ToInt32(Console.ReadLine());
            int result = Stepen(number, step);
            Console.WriteLine($"{result}");
            Console.ReadKey();

        }
        static int Stepen(int i, int j)
        {
            int result = i;
            for (int count = 1; count < j ; count++)
            {
                result = result*i;
            }
            return result;
        }
    }
}