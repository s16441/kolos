using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s16441Kolos.Models
{
    public class Musician_Track
    {
        [Key]
        [DatabaseGenerated
          (DatabaseGeneratedOption.Identity)]
        public int IdMusicianTrack { get; set; }
        [ForeignKey("IdTrack")]
        public int IdTrack { get; set; }

        public int IdMusician { get; set; }

       
        [ForeignKey("IdMusician")]
       public virtual Musician Musician { get; set; }

       

    }
}