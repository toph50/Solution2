using System.Numerics;

namespace ConsoleApp1
{
    internal class Program
    {
        static byte[] ConvertToDigit(long n)
        {
            List<byte> digits = new List<byte>();
            while(n > 0)
            {
                digits.Add((byte)(n % 10));
                n /= 10;

            }
            digits.Reverse();
            return digits.ToArray();
        }
        public static long NextBiggerNumber(long n)
        {
            var digits = ConvertToDigit(n);
            List<byte> sortedDigits = new List<byte>();
            sortedDigits.Add(digits[^1]);
            for (int i = digits.Length - 2; i >= 0; i--)
            {
                if (digits[i] < digits[i + 1])
                {
                    sortedDigits.Add(digits[i]);
                    sortedDigits.Sort();
                    var m = sortedDigits.FindIndex(d => d > digits[i]);
                    digits[i] = sortedDigits[m];
                    sortedDigits.RemoveAt(m);
                    foreach(var digit in sortedDigits)
                    {
                        digits[++i] = digit;
                    }
                    return long.Parse(string.Concat(digits));

                }
                sortedDigits.Add(digits[i]);
            }
            return -1;
        }
        static int[][] GenerateJaggedArray(int rows)
        {
            Loop<int>.Initialize(Enumerable.Range(1, rows));
            int[][] jaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                {
                    jaggedArray[i][j] = Loop<int>.Value;
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
            int rows = jaggedArray.Length*2;
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
                rows--;
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
            Console.WriteLine(string.Join(" ,",new long[] { 59884848459853, 336208743 }.Select(NextBiggerNumber)));

        }
    }
}