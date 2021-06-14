using System;

namespace Exercise6
{
    class Program
    {
        public static void PrintDiamond(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = rows; j > i + 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 2 * rows - 1; j > 2 * i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.Write("Enter number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintDiamond(n);

        }
    }
}
