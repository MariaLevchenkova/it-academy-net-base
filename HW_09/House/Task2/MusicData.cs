namespace Task2
{
    public class MusicData 
    {
        private string singer;
        private int length;

        public MusicData(string singer, int length)
        {
            this.singer = singer;
            this.length = length;
        }

        public override string ToString()
        {
            return "Singer: " + singer + "lenght seconds: " + length;
        }
    }
}
