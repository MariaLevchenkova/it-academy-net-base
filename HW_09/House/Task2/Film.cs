using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Film
    {
        private ItemData itemData;

        private FilmData filmData;

        public Film(ItemData itemData, FilmData filmData)
        {
            this.itemData = itemData;
            this.filmData = filmData;
        }

        public void Play()
        {
            Console.WriteLine("Item Data: " + itemData.ToString());
            Console.WriteLine("Film Data: " + filmData.ToString());
        }
    }
}
