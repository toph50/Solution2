namespace ConsoleApp1
{
    internal class Program
    {
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
            Console.WriteLine("Hello, World!");
        }
    }
}