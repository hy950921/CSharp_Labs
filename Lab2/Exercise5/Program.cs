using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            // box 1
            Box b1 = new Box();
            b1.SetBreadth(10);
            b1.SetHeight(10);
            b1.SetLength(10);
            double volume1 = b1.GetVolume();
            Console.WriteLine($"Volume of box1 is: {volume1}");

            // box 2
            Box b2 = new Box();
            b2.SetBreadth(20);
            b2.SetHeight(20);
            b2.SetLength(20);
            double volume2 = b2.GetVolume();
            Console.WriteLine($"Volume of box1 is: {volume2}");

            // box 3
            Box b3 = new Box();
            b3.SetBreadth(30);
            b3.SetHeight(30);
            b3.SetLength(30);
            double volume3 = b3.GetVolume();
            Console.WriteLine($"Volume of box1 is: {volume3}");
        }
    }
}
