namespace Task_02
{
    public class Film : Item
    {
        private string director;
        private string mainActor;
        private string mainActress;

        public Film(
            string name,
            string code,
            string category,
            int size,
            string director,
            string mainActor,
            string mainActress) : base(name, code, category, size)
        {
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
        }

        public override void Play()
        {
            Console.WriteLine("Film Data: " + ToString());
        }

        public override string ToString()
        {
            return "Director: " + director + "Main Actor: " + mainActor + " Main Actress: " + mainActress + base.ToString();
        }
    }
}
