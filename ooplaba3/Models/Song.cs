using System.Collections.Generic;

namespace ooplaba3.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";

        // Связь многие ко многим с артистами
        public List<ArtistSong> ArtistSongs { get; set; } = new();
    }
}
