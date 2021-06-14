using System;

namespace Exercise5
{
    class Program
    {
        public static void PrintBinaryTriangle()
        {
            int output = 0;
            Console.Write("Enter the Number of Rows: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (output == 1)
                    {
                        Console.Write("0");
                        output = 0;
                    }
                    else if (output == 0)
                    {
                        Console.Write("1");
                        output = 1;
                    }
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            PrintBinaryTriangle();
        }
    }
}
