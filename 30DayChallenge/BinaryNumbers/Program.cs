// https://www.hackerrank.com/challenges/30-binary-numbers/problem

using System;

namespace BinaryNumbers
{
    class Solution
    {
        static int CountOneInBinary(int num)
        {
            int countOne = 0;
            int tempOne = 0;

            while (num > 0)
            {
                if (num % 2 == 1)
                {
                    tempOne++;
                    if (tempOne > countOne)
                    {
                        countOne = tempOne;
                    }
                }
                else
                {
                    tempOne = 0;
                }
                num /= 2;
            }

            return countOne;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountOneInBinary(n));
        }
    }
}
