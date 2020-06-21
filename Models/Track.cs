using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s16441Kolos.Models
{
    public class Track
    {
        [Key]
        [DatabaseGenerated
         (DatabaseGeneratedOption.Identity)]
        public int IdTrack { get; set; }
        [MaxLength(20)]
        public string TrackName { get; set; }

        public float Duration{ get; set; }
        [ForeignKey("IdMusicAlbum")]
        public int IdMusicAlbum{ get; set; }

        public ICollection<Musician_Track> Musician_Tracks { get; set; }
        public virtual Album Album { get; set; }


    }
}