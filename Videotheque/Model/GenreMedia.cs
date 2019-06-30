﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Videotheque.Model
{
    public class GenreMedia
    {
        public int IdGenre { get; set; }
        public int IdMedia { get; set; }

        [ForeignKey(nameof(IdGenre))]
        public Genre Genre { get; set; } = new Genre();
        [ForeignKey(nameof(IdMedia))]
        public Media Media { get; set; } = new Media();
    }
}