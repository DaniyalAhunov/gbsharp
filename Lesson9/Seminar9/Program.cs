//Задача Из двумерного массива целых чисел удалить строку и столбец,
//на пересечении которых расположен наименьший элемент.
namespace Seminar9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = new Random().Next(3, 7);
            int m = new Random().Next(3, 7);
            int[,] array = new int[n, m];
            FillArray(array);
            PrintArray(array);
            int[,] resultArray = RemoveRowsCols(array);
            Console.WriteLine();
            PrintArray(resultArray);
            
        }
        static void FillArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(0, 99);
                }
            }
        }
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[] MinIndex(int[,]array)
        {
            int[] minIndex = new int[2];
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j]<min)
                    {
                        min = array[i, j];
                        minIndex[0] = i;
                        minIndex[1] = j;
                          
                    }
                }
            }
            return minIndex;
        }
        static int[,] RemoveRowsCols(int[,]array)
        {
            int[] minIndex = MinIndex(array);
            Console.WriteLine(minIndex[0]);
            Console.WriteLine();
            Console.WriteLine(minIndex[0]);
            int[,] arrayResult = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
            for(int i = 0, m = 0;i<array.GetLength(0)&& m<arrayResult.GetLength(0); i++,m++)
            {
                if(i==minIndex[0])
                {
                    i++;
                }
                for (int j = 0, n = 0; j < array.GetLength(1)&&n<arrayResult.GetLength(1); j++,n++)
                {
                    if (j == minIndex[1])
                    {
                        j++;
                    }
                    arrayResult[m, n] = array[i, j];
                }
            }
            return arrayResult;
        }
    }
}