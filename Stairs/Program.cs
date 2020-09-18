using System;

namespace Stairs
{
    class Program
    {  // Returns number of ways  
       // to reach s'th stair 
        static int countWays(int n, int m)
        {
            int[] res = new int[n + 1];
            int temp = 0;
            res[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                int s = i - m - 1;
                int e = i - 1;
                if (s >= 0)
                {
                    temp -= res[s];
                }
                temp += res[e];
                res[i] = temp;
            }
            return res[n];
        }

        // Driver Code  
        public static void Main()
        {
            int n = 5, m = 3;
            Console.WriteLine("Number of ways = " + countWays(n, m));
        }

    }
}
