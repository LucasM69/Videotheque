using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Videotheque.enums;

namespace Videotheque.Model
{
    public class Personne
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Civilite Civilite { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Nationalite { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Photo { get; set; }

        [InverseProperty(nameof(PersonneMedia.Personne))]
        public List<PersonneMedia> LesMedias { get; set; } = new List<PersonneMedia>();

    }
}
