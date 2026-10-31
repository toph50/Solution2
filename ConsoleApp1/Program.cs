using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static int[][] GenerateJaggedArray(int rows)
        {
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    jaggedArray[i][j] = i + j+1;
                }
            }
            return jaggedArray;
        }
        static T SumArray<T>(IEnumerable<T> array) where T : INumber<T>
        {
            T sum = T.Zero;
            foreach (T item in array)
            {
                sum += item;
            }
            return sum;
        }



        static void PrintJaggedArray(int[][] jaggedArray)
        {
            int rows = jaggedArray.Length;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                rows--;
                for(int k = 0; k < rows; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"[{jaggedArray[i][j]}]");
                }
                Console.WriteLine();
            }
        }
        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            int sqrt = (int)Math.Sqrt(number);
            for (int i = 2; i <= sqrt; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[][] jaggedArray = GenerateJaggedArray(8);
            PrintJaggedArray(jaggedArray);

        }
    }
}