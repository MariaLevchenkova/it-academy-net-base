using HW13;

public class Song
{
    public Song(string title, int minutes, string author, int albumYear, Genre genre)
    {
        Title = title;
        Minutes = minutes;
        Author = author;
        AlbumYear = albumYear;
        Genre = genre;
    }
    public string Title { get; }
    public int Minutes { get; }
    public string Author { get; }
    public int AlbumYear { get; }
    public Genre Genre { get; }
}

