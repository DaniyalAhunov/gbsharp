//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
namespace homework002
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
            
            Console.WriteLine("Введите первую точку первой прямой: ");
            double k1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую точку первой прямой: ");
            double b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первую точку второй прямой: ");
            double k2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вторую точку второй прямой: ");
            double b2 = Convert.ToInt32(Console.ReadLine());
            double y1 = Ygr(k1, b1, k2, b2);
            double y2 = Ygr(k2, b2, k1, b1);
            double x = Ics(k1,b1,k2,b2);
            if (y1 == y2)
            {
                Console.WriteLine($"({x};{y1})");
            }
            else
            {
                Console.WriteLine($"Ваши линии не пересекаются");
            }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка введите числа");
            }



        }
        static double Ics (double k1, double b1, double k2, double b2) 
        {
            double x = (b2 - b1)/(k1 - k2);
            return x;
        }
        static double Ygr (double k1, double b1, double k2, double b2)
        {
            double x = Ics(k1, b1, k2, b2); 
            double y = k1 * x + b1; 
            return y;
        }

    }
    
}