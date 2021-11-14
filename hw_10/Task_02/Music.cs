using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Music : Item
    {
        private string singer;
        private int length;

        public Music(string name, string code, string category, int size, string singer, int length) : base(name, code, category, size)
        {
            this.singer = singer;
            this.length = length;
        }

        public override void Play()
        {
            Console.WriteLine("Music Data: " + ToString());
        }

        public override string ToString()
        {
            return "Singer: " + singer + "lenght seconds: " + length + base.ToString();
        }
    }
}
