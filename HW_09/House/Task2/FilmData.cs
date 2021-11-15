namespace Task2
{
    public class FilmData
    {
        private string director;
        private string mainActor;
        private string mainActress;

        public FilmData(string director, string mainActor, string mainActress)
        {
            this.director = director;
            this.mainActor = mainActor;
            this.mainActress = mainActress;
        }

        public override string ToString()
        {
            return "Director: " + director + "Main Actor: "+mainActor + " Main Actress: "+ mainActress;
        }
    }
}
