using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            sol.CreateArray();
            int[] arr = sol.FillArray();
            //sol.Display();
            int ans = sol.Solutions(arr);
            Console.WriteLine($"The most often value in the array is: {ans}");

        }
    }
}
