using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace s16441Kolos.Models
{
    public class MusiciansDbContext : DbContext
    {
        public DbSet<Musician> Musicians { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<Musician_Track> Musician_Tracks { get; set; }

        public DbSet<MusicLabel> MusicLabels { get; set; }

        public DbSet<Album> Albums { get; set; }


    }
}
