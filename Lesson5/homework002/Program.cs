//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
namespace homework002
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = new Random().Next(5,11);
            int[] arrayNumber = new int[count];
            Console.WriteLine("Первоночальный массив: ");
            FillArray(arrayNumber);
            Console.WriteLine();
            int sum = SumNechet(arrayNumber);
            Console.WriteLine($"Сумма чисел нечётных элементов: {sum}");
            Console.ReadKey();

        }
        /// <summary>///
        ///Заполнение массива///
        /// </summary>///
        public static void FillArray(int[] array)
        #region 
        {
            
            for (int i = 0; i < array.Length;i++)
            {
                int number = new Random().Next(-40,41);
                array[i] = number;
                Console.Write($"{array[i]} ");
            }
            

        }
        #endregion
        /// <summary>///
        ///Поиск нечётных элементов и их сумирование///
        /// </summary>///
        static int SumNechet(int[] array)
        #region 
        {
            int sum = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + Convert.ToInt32(array[i]);
                    Console.WriteLine(sum);  
                }
            }
            return sum;
        }
        #endregion
    }
}
