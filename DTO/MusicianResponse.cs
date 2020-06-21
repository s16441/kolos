using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace s16441Kolos.DTO
{
    public class MusicianResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public IEnumerable<Track> Tracks { get; set; }
    }

    public class Track
    {
        public string Name { get; set; }
        public int Id { get; set; }
   
        public float Duration { get; set; }
    }
}