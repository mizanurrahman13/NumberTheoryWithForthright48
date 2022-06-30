using System;

namespace PrimalityTestNaiveMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    var number = int.Parse(Console.ReadLine());
            //    Console.WriteLine(isPrime(number));
            //}

            while (true)
            {
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine(isPrimeSqrt(number));
            }
        }

        static bool isPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i < n; i++)
            {
                // If it is possible to divide n with a number other than 1 and n, then it is not prime
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool isPrimeSqrt(int n)
        {
            if (n <= 1) return false;
            int sqrtn = (int)Math.Sqrt(n);
            for (int i = 2; i <= sqrtn; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
