using System;

namespace Exercise4
{
    class A
    {
        static int n = 1;   //static member is class member
        public void F()
        {
            n++;
        }
        public void Report()
        {
            Console.WriteLine(n.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A x = new A(), y = new A();
            x.F();
            x.Report();
            y.F();
            y.Report();
        }
    }
}
