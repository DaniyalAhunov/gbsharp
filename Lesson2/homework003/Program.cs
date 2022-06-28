namespace homework003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели ");
            int Day = Convert.ToInt32(Console.ReadLine());
            switch (Day)    
            {
                case 1:
                Console.WriteLine("Будний день: Говорят это самый тяжелый день Понедельник!!!");
                break;
                case 2:
                Console.WriteLine("Будний день: Работать иди сегодня Вторкник!!");
                break;
                case 3:
                Console.WriteLine("Будний день: Вот и половина сегодня все же на работу Среда!!!");
                break;
                case 4:
                Console.WriteLine("Будний день: Потерпи осталось пару дней Четверг!!!");
                break;
                case 5:
                Console.WriteLine("Будний день: Вот ты и на финишной прямой Пятница!!!");
                break;
                case 6:
                Console.WriteLine("Выходной: УРАААА вот ты и дожил Суббота!!!");
                break;
                case 7:
                Console.WriteLine("Выходной: Сегодня тоже можешь отдохнуть но не забывай завтра Понедельник Ну а сегодня Воскреснье!!!");
                break;

                default:
                Console.WriteLine("УПС такого дня нет ");
                break;
            }
           Console.ReadKey();
        }
    }
}