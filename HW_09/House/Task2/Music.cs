using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Music
    {
        private ItemData itemData;
        private  MusicData musicData;

        public Music(ItemData itemData, MusicData musicDate)
        {
            this.itemData = itemData;
            this.musicData = musicDate;
        }

        public void Play()
        {
            Console.WriteLine("Item Data: " + itemData.ToString());
            Console.WriteLine("Music Data: " + musicData.ToString());
        }
    }
}
