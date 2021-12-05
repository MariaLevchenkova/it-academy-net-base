using System.Collections.Generic;

namespace HW13
{
    public interface ISongService
    {
        List<Song> Search(Genre genre);
    }
}
