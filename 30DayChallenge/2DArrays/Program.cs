// https://www.hackerrank.com/challenges/30-2d-arrays/problem

using System;

namespace _2DArrays
{
    class Solution {
    static void Main(string[] args) {
        int[][] arr = new int[6][];
        int maxNum = -10000;

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }
        
        for (int i = 0; i < arr.GetLength(0) - 2; i++)
        {
            for (int j = 0; j < arr[0].GetLength(0) - 2; j++)
            {
                try
                {
                    int tempNum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                        + arr[i + 1][j + 1]
                        + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    
                    if (tempNum > maxNum)
                    {
                        maxNum = tempNum;
                    }
                    
                } catch(Exception e) {
                    continue;
                }    
            }
        }
        
        Console.WriteLine(maxNum);
    }
}
}
