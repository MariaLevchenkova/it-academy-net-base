using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Door d = new Door("red");

            House h = new House(50, d);

            Person p = new Person( "Tom", h );
            p.ShowData();
        }
    }
}
