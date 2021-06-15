using System;

namespace Exercise8
{
    abstract class A
    {
        int x;
        public abstract void F(int n);
        private virtual void G(uint n)
        {
            //x = n as int;
        }
        public string ToString()
        {
            return x.ToString(); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
