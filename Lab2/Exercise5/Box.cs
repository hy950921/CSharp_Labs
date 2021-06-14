
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public void SetLength(double len)
        {
            length = len;
        }

        public void SetBreadth(double brea)
        {
            breadth = brea;
        }

        public void SetHeight(double hei)
        {
            height = hei;
        }

        public double GetVolume()
        {
            return length * breadth * height;
        }


    }
}
