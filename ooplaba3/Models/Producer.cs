using System.Collections.Generic;

namespace ooplaba3.Models
{
    public class Producer
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        // Один ко многим: один продюсер — много артистов
        public List<Artist> Artists { get; set; } = new();
    }
}
