// https://www.hackerrank.com/challenges/30-sorting/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        // Write Your Code Here
        int swapCount = 0;

        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a.Length - 1 - i; j++)
            {
                if (a[j] > a[j+1])
                {
                    swap(ref a[j], ref a[j+1]);
                    swapCount++;
                }
            }
        }

        Console.WriteLine($"Array is sorted in {swapCount} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Length-1]}");
    }
}