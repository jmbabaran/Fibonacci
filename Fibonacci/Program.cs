using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Fibo(7); //output 13


            Console.WriteLine("Result: " + result);
        }

        public static int Fibo(int n)
        {
            if (n <=1)
            {
                return n;
            } else
            {
                return Fibo(n - 1) + Fibo(n - 2);
            }

        }
    }
}
