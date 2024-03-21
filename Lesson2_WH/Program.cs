namespace Lesson2_WH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            Console.WriteLine("Исходный двумерный массив:");
            PrintArray2D(a);
            Console.WriteLine();

            int[,] sortArray2D = SortingArray2D(a);

            Console.WriteLine("Отсортированный двумерный массив:");
            PrintArray2D(sortArray2D);
        }
        static void PrintArray2D(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j == a.GetLength(1) - 1)
                    {
                        Console.WriteLine(a[i, j]);
                    }
                    else
                    {
                        Console.Write(a[i, j] + ", ");
                    }
                }
            }
        }
        static int[,] SortingArray2D(int[,] array2D)
        {
            int numberOfRows = array2D.GetLength(0);
            int numberOfColumns = array2D.GetLength(1);
            int[] array1D = ConvertArray2DToArray1D(array2D);
            for (int i = 0; i < array1D.Length - 1; i++)
            {
                for (int j = 0; j < array1D.Length - i - 1; j++)
                {
                    if (array1D[j] > array1D[j + 1])
                    {
                        int temp = array1D[j];
                        array1D[j] = array1D[j + 1];
                        array1D[j + 1] = temp;
                    }
                }
            }
            int[,] sortArray2D = ConvertArray1DToArray2D(array1D, numberOfRows, numberOfColumns);
            return sortArray2D;
        }
        static int[] ConvertArray2DToArray1D(int[,] array2D)
        {
            int arraySize = array2D.GetLength(0) * array2D.GetLength(1);
            int[] array1D = new int[arraySize];
            int k = 0;

            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    array1D[k] = array2D[i, j];
                    k++;
                }
            }
            return array1D;
        }
        static int[,] ConvertArray1DToArray2D(int[] array1D, int numberOfRows, int numberOfColumns)
        {
            int[,] array2D = new int[numberOfRows, numberOfColumns];
            int k = 0;
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    array2D[i, j] = array1D[k];
                    k++;
                }
            }
            return array2D;
        }
    }
}
