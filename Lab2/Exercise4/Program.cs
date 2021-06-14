using System;
using System.Collections.Generic;


namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Solution sol = new Solution();
            int[,] matrix = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            List<int> res = new List<int>();
            res = sol.PrintMatrixSpiral(matrix);

            foreach (int val in res)
            {
                Console.Write($"{val} ");
            }

        }
    }
}
