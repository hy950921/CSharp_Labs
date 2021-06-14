using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle : Shape1
    {
        public void GetLengthAndBreadth()
        {
            Console.Write("Please enter the length: ");
            l = float.Parse(Console.ReadLine());
            Console.Write("Please enter the breadth: ");
            b = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return l * b;
        }

        public override float Circumference()
        {
            return 2 * (l + b);
        }

    }
}
