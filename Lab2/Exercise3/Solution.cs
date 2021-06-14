
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    class Solution
    {
        public int Solutions(int num1, int num2)
        {
            int count = 0;
            for (int i = 1; i <= num2; i++)
            {
                if (i < num1) continue;
                if (i > num2) break;

                if (CheckPerfectNumber(i))
                {
                    //Console.WriteLine($"I found it {i}");
                    count++;
                }
            }
            return count;
        }

        public bool CheckPerfectNumber(int n )
        {
            double sq = Math.Sqrt(n);

            return sq - Math.Floor(sq) == 0;
        }
    }
}
