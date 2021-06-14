using System;

namespace Exercise2
{
    class Arithmetic
    {
        public double num1, num2;

        public double Addition()
        {
            return num1 + num2;
        }

        public double Substration()
        {
            return num1 - num2;
        }

        public double Multiplication()
        {
            return num1 * num2;
        }

        public double Division()
        {
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Arithmetic arith = new Arithmetic();

            Console.WriteLine("Enter the number1:");
            arith.num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number2:");
            arith.num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 1 for additon, 2 for substration, 3 for multiplication, 4 for division");
            string order = Console.ReadLine();
            double res;
            switch (order)
            {
                case "1":
                    res = arith.Addition();
                    Console.WriteLine($"The result is: {res}");
                    break;
                case "2":
                    res = arith.Substration();
                    Console.WriteLine($"The result is: {res}");
                    break;
                case "3":
                    res = arith.Multiplication();
                    Console.WriteLine($"The result is: {res}");
                    break;
                case "4":
                    res = arith.Division();
                    Console.WriteLine($"The result is: {res}");
                    break;
            }

        }
    }
}
