using System;

namespace DemoTask
{
    public class student
    {
        string name, address;
        int mobile;

        public void GetData()
        {
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your Address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter your Mobile Number:");
            mobile = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Student Address: " + address);
            Console.WriteLine("Student Mobile: " + mobile);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            student s1 = new student();
            s1.GetData();
            s1.DisplayData();
            //Console.ReadKey();
        }
    }
}
