using System;

namespace Task1
{
    public class Door
    {
        private string color;

        public Door(string color)
        {
            this.color = color;
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is " + color);
        }
    }
}
