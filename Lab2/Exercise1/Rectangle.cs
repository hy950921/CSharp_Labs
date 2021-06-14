using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class Rectangle
    {
        double length = 1;
        double width = 1;

        public void GetData()
        {
        again:
            Console.Write("Enter length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            width = Convert.ToInt32(Console.ReadLine());

            if (length < 0 || length > 20 || width < 0 || width > 20)
            {
                Console.WriteLine("Please enter length and width between 0 and 20");
                goto again;
            }
        }

        public double GetArea()
        {
            return length * width;
        }

        public double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public void Display()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Wideth: {width}");
            double area = GetArea();
            Console.WriteLine($"Area: {area}");
            double perimeter = GetPerimeter();
            Console.WriteLine($"Perimeter: {perimeter}");
        }

    }
}
