//Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка
//Задача 2. Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
namespace seminar
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int min = Int32.MinValue;
                int max = Int32.MaxValue;
                Console.WriteLine("Введите номер четверти: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                    {
                        Console.WriteLine($" Диапазон 1 четверти: 0 < X < {max} и 0 < Y < {max}"); 
                    }
                else if (num == 2)
                    {
                        Console.WriteLine($" Диапазон 2 четверти: {min} < X < 0 и 0 < Y < {max} "); 
                    }
                else if (num == 3)
                    {
                        Console.WriteLine($" Диапазон 3 четверти: {min} < X < 0 и {min} < Y < 0 "); 
                    }
                else if (num == 4)
                    {
                        Console.WriteLine($" Диапазон 4 четверти:  0 < X < {max} и {min} < Y < 0 "); 

                    }
                else
                    {
                        Console.WriteLine(" Диапазона не существует ");
                    }

            Console.ReadKey();
            }
            catch 
            {
                Console.WriteLine($" Введите нужное значение");
            }
        }
    }
}