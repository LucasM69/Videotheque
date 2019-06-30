﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Videotheque.DataAccess;
using Videotheque.enums;
using Videotheque.Tools;

namespace Videotheque.Model
{
    public class Media :  ToolsDataController<Media>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 
        public string Titre { get; set; }
        public bool Vu { get; set; }
        public int Note { get; set; }
        public string Commentaire { get; set; }
        public string Synopsis { get; set; }
        public int AgeMin { get; set; }
        public bool SupportPhysique { get; set; }
        public bool SupportNumerique { get; set; }
        public string Image { get; set; }
        public DateTime DateSortie { get; set; }
        public TimeSpan Duree { get; set; }
        public TypeMedia TypeMedia { get; set; }
        public Langue LangueVO { get; set; }


        public Langue LangueMedia { get; set; }
        public Langue SousTitres { get; set; }

        [InverseProperty(nameof(GenreMedia.Media))]
        public List<GenreMedia> LesGenres { get; set; } = new List<GenreMedia>();
        [InverseProperty(nameof(PersonneMedia.Media))]
        public List<PersonneMedia> LesPersonnes { get; set; } = new List<PersonneMedia>();
        [InverseProperty(nameof(Episode.Media))]
        public List<Episode> LesEpisodes { get; set; } = new List<Episode>();

    }
}
