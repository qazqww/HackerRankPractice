// https://www.hackerrank.com/challenges/time-conversion/problem

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        /*
         * Write your code here.
         */
        if (s.Contains("PM") && s.Substring(0, 2) != "12")
        {
            string newHour = (int.Parse(s.Substring(0, 2)) + 12).ToString();
            return newHour + s.Substring(2, s.Length - 4);
        }
        else if (s.Contains("AM") && s.Substring(0, 2) == "12")
        {
            return "00" + s.Substring(2, s.Length - 4);
        }
        else
        {
            return s.Substring(0, s.Length - 2);
        }
    }

    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
