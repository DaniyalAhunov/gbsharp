namespace example001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты А точки через запятую ");
            string a = Console.ReadLine().ToString();
            string[] asplit = a.Split(',');
            int xa = Convert.ToInt32(asplit[0]);
            int ya = Convert.ToInt32(asplit[1]);
            int za = Convert.ToInt32(asplit[2]);
            Console.WriteLine("Введите координаты B точки через запятую ");
            string b = Console.ReadLine().ToString();
            string[] bsplit = b.Split(',');
            int xb = Convert.ToInt32(bsplit[0]);
            int yb = Convert.ToInt32(bsplit[1]);
            int zb = Convert.ToInt32(bsplit[2]);
            double ab = GetRootNumbers(xa, ya, za, xb, yb, zb);
            Console.WriteLine($"Точка в 3D простанстве {ab}");
            Console.ReadKey();

        }
        static double GetRootNumbers (int xa, int ya, int za, int xb, int zb, int yb)
        {
            double log = (xa + xb) * (xa + xb) + (ya + yb) * (ya + yb) + (za + zb) * (za + zb);
            double ab = Math.Sqrt(log);
            return ab;

        }
    }
}