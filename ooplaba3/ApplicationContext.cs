using Microsoft.EntityFrameworkCore;
using ooplaba3.Models;

namespace ooplaba3
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Producer> Producers => Set<Producer>();
        public DbSet<Artist> Artists => Set<Artist>();
        public DbSet<Song> Songs => Set<Song>();
        public DbSet<ArtistSong> ArtistSongs => Set<ArtistSong>();

        public ApplicationContext(DbContextOptions options) => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=helloapp.db");
        }
    }
}
