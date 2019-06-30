using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Videotheque.Model
{
    public class Genre
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Libelle { get; set; }

        [InverseProperty(nameof(GenreMedia.Genre))]
        public List<GenreMedia> LesMedias { get; set; } = new List<GenreMedia>();

    }
}
