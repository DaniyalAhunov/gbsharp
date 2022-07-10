//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
namespace homework003
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
            int min = MinNumber(arrayNumber);
            int max = MaxNumber(arrayNumber);
            Console.WriteLine($"Разница между максимальным числом: {max} и минимальным числом: {min} ровна: {max-min}");
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
                int number = new Random().Next(0,1000);
                array[i] = number;
                Console.Write($"{array[i]} ");
            }
        }
        #endregion
        //Поиск максимального числа в массиве
        static int MaxNumber(int[] array)
        #region
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                } 
            }
            return maxValue;
        }
        #endregion
        //Поиск миниманого  числа в массиве
        static int MinNumber(int[] array)
        #region
        {
            int minValue = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                } 
            }
            return minValue;
        }
        #endregion
    }
}