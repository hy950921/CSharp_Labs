using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a value: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter one more value: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Solution sol = new Solution();
            int res = sol.Solutions(num1, num2);
            Console.WriteLine($"The number of perfect squres in between {num1} and {num2} is: {res}");
        }
    }
}
