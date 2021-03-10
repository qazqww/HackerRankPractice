using System;

namespace NestedLogic
{
    class Solution
    {
        static int FineState(int[] returned, int[] due)
        {
            if (returned[2] < due[2])
            {
                return 0;
            }
            else if (returned[2] > due[2])
            {
                return 10000;
            }
            else if (returned[1] > due[1])
            {
                return 500 * (returned[1] - due[1]);
            }
            else if (returned[0] > due[0])
            {
                return 15 * (returned[0] - due[0]);
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            string[] returned_temp = Console.ReadLine().Split(' '); // [0]day [1]month [2]year
            int[] returned = Array.ConvertAll(returned_temp, Int32.Parse);
            string[] due_temp = Console.ReadLine().Split(' ');
            int[] due = Array.ConvertAll(due_temp, Int32.Parse);

            Console.WriteLine(FineState(returned, due));
        }
    }
}
