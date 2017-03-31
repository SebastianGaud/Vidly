using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength( 150 )]
        public string Name { get; set; }

        public DateTime AddedDate { get; set; }

        [Display( Name = "Release Date" )]
        public DateTime ReleaseDate { get; set; }

        [Display( Name = "Number in Stock" )]
        [Range( 1 , 20 )]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        public Genre Genre { get; set; }

        [Display( Name = "Genre" )]
        [Required]
        public int GenreId { get; set; }
    }
}