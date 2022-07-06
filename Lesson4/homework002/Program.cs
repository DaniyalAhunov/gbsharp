// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
namespace homework002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число ");
            string vvod = Console.ReadLine();
            int summa = Summa(vvod);
            Console.WriteLine(summa);
        }

        static int Summa(string number)
        {
            int count = number.Length;
            int newSumma = 0;
            for (int i = 0; i < count; i++)
            {
                string numbers = number[i].ToString();
                newSumma = newSumma + Convert.ToInt32(numbers);
            }
            return newSumma;
        }
    }
}