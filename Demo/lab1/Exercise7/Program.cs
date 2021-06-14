using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Pin Number: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            int balance = 1000;
            while (true)
            {
                Console.Write("\n");
                Console.WriteLine("********Welcome to ATM Service**************\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("*********************************************\n");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 4)
                {
                    break;
                }
                switch(choice)
                {
                    case 1:
                        Console.Write("\n");
                        Console.WriteLine($"Your balance is: {balance}");
                        break;
                    case 2:
                        Console.Write("\n");
                        Console.Write($"Your withdraw is: ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        if (withdraw > balance)
                        {
                            Console.WriteLine("You don't have that much money!");
                        }
                        else
                        {
                            balance -= withdraw;
                            Console.WriteLine($"Your current balance is {balance}");
                        }
                        break;
                    case 3:
                        Console.Write("\n");
                        Console.Write($"Your deposit is: ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        balance += deposit;
                        Console.WriteLine($"Your current balance is {balance}");
                        break;
                }
            }
        }
    }
}
