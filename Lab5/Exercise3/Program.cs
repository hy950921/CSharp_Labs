using System;

namespace Exercise3
{
    class Program
    {
        static void F(string s)
        {
            s += "world";
        }
        static void Main(string[] args)
        {

            string s = "Hello";
            F(s);
            Console.WriteLine(s);   //string is immutable 
        }
    }
}
