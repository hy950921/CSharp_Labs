using System;

namespace Exercise2
{
    class A
    {
        protected int n = 99;
        public A()
        {
            n++;
            Console.WriteLine("n += " + n.ToString());
        }
    }
    class B : A
    {
        public B()
        {
            n = 98;
            Console.WriteLine("n == " + n.ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            A a = new B();
        }
    }
}
