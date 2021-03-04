// https://www.hackerrank.com/challenges/30-running-time-and-complexity/problem

using System;

namespace RunningTimeComplexity
{
    class Solution
    {
        static void isPrime(int num)
        {
            if (num == 1)
            {
                Console.WriteLine("Not prime");
                return;
            }

            int i = 1;
            while (++i <= Math.Sqrt(num))
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Not prime");
                    return;
                }                
            }

            Console.WriteLine("Prime");
        }

        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            while(count-- > 0)
            {
                int num = int.Parse(Console.ReadLine());
                Solution.isPrime(num);
            }
        }
    }
}
