using System;

namespace Exercise4
{
    class Program
    {
        public static void DisplayArmstrongNumbers(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                int n = i, armstrong = 0;
                while (n > 0)
                {
                    armstrong += Convert.ToInt32((n % 10)* (n % 10)* (n % 10));
                    n /= 10;
                }
                if (armstrong == i)
                {
                    Console.WriteLine(i);
                }
            }

        }
        

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.Write("Enter the first number: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enther the second number: ");
            int end = Convert.ToInt32(Console.ReadLine());
            DisplayArmstrongNumbers(start, end);
        }
    }
}
