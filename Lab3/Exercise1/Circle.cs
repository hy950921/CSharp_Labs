using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Circle : Shape1
    {
        static readonly double pi = Math.PI;
        public void GetRadius()
        {
            Console.Write("Please enter the radius: ");
            r = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return (float) Math.Round(pi * r * r, 1);
        }

        public override float Circumference()
        {
            return (float) Math.Round(2 * pi * r, 1);
        }

    }
}
