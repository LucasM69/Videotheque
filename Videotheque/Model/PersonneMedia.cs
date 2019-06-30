﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Videotheque.enums;

namespace Videotheque.Model
{
    public class PersonneMedia
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public int IdMedia { get; set; }
        public int IdPersonne { get; set; }
        public Fonction Fonction { get; set; }
        public string Role { get; set; }

        [ForeignKey(nameof(IdMedia))]
        public Media Media { get; set; } = new Media();
        [ForeignKey(nameof(IdPersonne))]
        public Personne Personne { get; set; } = new Personne();

    }
}
