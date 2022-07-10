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
            int sum = SumNechet(arrayNumber);
            Console.WriteLine($"Разнича между максимальным и минимальным числом: {sum}");
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
    }
}