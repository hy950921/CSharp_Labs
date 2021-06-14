using System;

namespace Exercise1
{
    class Program
    {
        public static void Calculate(Shape1 s)
        {
            Console.WriteLine("Area : {0}", s.Area());
            Console.WriteLine("Circumference : {0}", s.Circumference());
        }
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.GetLengthAndBreadth();
            Calculate(rec);
            Console.WriteLine("");
            Circle cir = new Circle();
            cir.GetRadius();
            Calculate(cir);
            Console.ReadKey();
        }
    }
}
