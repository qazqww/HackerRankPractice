// https://www.hackerrank.com/challenges/plus-minus/problem

using System;
using System.Linq;

class Solution
{
    // Complete the plusMinus function below.
    static void plusMinus(int[] arr)
    {
        double posRatio = (double)arr.Where(i => i > 0).Count() / arr.Length;
        double negRatio = (double)arr.Where(i => i < 0).Count() / arr.Length;
        double zeroRatio = (double)arr.Where(i => i == 0).Count() / arr.Length;
        Console.WriteLine($"{posRatio}\n{negRatio}\n{zeroRatio}");
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        plusMinus(arr);
    }
}
