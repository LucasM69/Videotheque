using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videotheque.Model
{
    public class Episode
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public int NumSaison { get; set; }
        public int NumEpisode { get; set; }
        public TimeSpan Duree { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public DateTime DateDiffusion { get; set; }
        public int IdMedia { get; set; }

        [ForeignKey(nameof(IdMedia))]
        public Media Media { get; set; } = new Media();

    }
}
