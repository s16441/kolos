﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace s16441Kolos.Models
{
    public class Musician
    {
        [Key]
        [DatabaseGenerated
            (DatabaseGeneratedOption.Identity)]
        public int IdMusician { get; set; }
        [MaxLength(30)]
        public string Firstname { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Nickname { get; set; }

        public ICollection<Musician_Track> Musician_Tracks { get; set; }
       


    }
}