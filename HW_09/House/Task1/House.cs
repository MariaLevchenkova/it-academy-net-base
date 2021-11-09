using System;

namespace Task1
{
    public class House
    {
        private int area;
        private  Door door;

        public House(int area, Door door)
        {
            this.area = area;
            this.door = door;
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a house, my area is " + area + " m2");
        }

        public Door GetDoor() 
        {
            return door;
        }
    }
}
