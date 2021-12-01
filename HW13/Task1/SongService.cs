using System;
using System.Collections.Generic;
using System.Linq;

namespace HW13
{
    public class SongService : ISongService
    {
        private readonly List<Song> songs;

        public SongService()
        {
            songs = new List<Song>
            {
                new Song("Song1", 3, "Author1", 2021, Genre.ClassicalMusic),
                new Song("Song2", 3, "Author2", 2021, Genre.ElectonicMusic),
                new Song("Song3", 3, "Author3", 2021, Genre.Jazz),
                new Song("Song4", 3, "Author4", 2021, Genre.HipHop),
                new Song("Song5", 3, "Author5", 2021, Genre.Rock),
            };
        }
        public List<Song> Search(Genre search)
        {
            List<Song> result = songs.Where(x => search.HasFlag(x.Genre)).ToList();
            return result;
        }
    }
}
