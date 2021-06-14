using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class House
    {
        public House(int area)
        {
            this.area = area;
            door = new Door();
        }

        protected int area;

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        protected Door door;

        public Door Door
        {
            get { return door; }
            set { door = value; }
        }

        public virtual void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2.", area);
        }


    }

    class Door
    {
        public Door()
        {
            color = "Brown";
        }

        public Door(string color)
        {
            this.color = color;
        }

        protected string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}.", color);
        }


    }
}
