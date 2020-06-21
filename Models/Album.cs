using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s16441Kolos.Models
{
    public class Album
    {
        [Key]
        [DatabaseGenerated
          (DatabaseGeneratedOption.Identity)]
        public int IdAlbum { get; set; }
        [MaxLength(30)]
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }
        [ForeignKey("IdMusicLabel")]
        public int IdMusicLabel { get; set; }

        public virtual MusicLabel MusicLabel { get; set; }
        public ICollection<Track> Track { get; set; }

    }
}