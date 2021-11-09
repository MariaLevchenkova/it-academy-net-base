using System;

namespace Task1
{
    public class Person 
    {
        private string name;

        private  House house;

        public Person(string name, House house)
        {
            this.name = name;
            this.house = house;
        }
        public void ShowData()
        {
            Console.WriteLine("I am " + name);
            house.ShowData();
            Door d= house.GetDoor();
            d.ShowData();
        }
    }
}
