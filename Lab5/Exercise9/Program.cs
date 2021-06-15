using System;

namespace Exercise9
{
    class A
    {
        int n;
        string s;
        public A(int n, string s)
        {
            this.n = n;
            this.s = s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A[] v = new A[3];
            v[0] = new A(100, "abc");
            v[1] = new A(10, "abc");
            v[2] = new A(1, "abc");

            Array.Sort(v);

            Console.WriteLine(v);
        }
    }
}
