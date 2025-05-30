using System.Collections.Generic;

namespace ooplaba3.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        // Внешний ключ на продюсера
        public int ProducerId { get; set; }
        public Producer? Producer { get; set; }

        // Связь многие ко многим с песнями
        public List<ArtistSong> ArtistSongs { get; set; } = new();
    }
}
