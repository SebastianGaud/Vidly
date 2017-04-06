using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.DTOS
{
    public class MovieDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength( 150 )]
        public string Name { get; set; }

        public DateTime AddedDate { get; set; }

        public DateTime ReleaseDate { get; set; }

        public GenreDTO Genre { get; set; }

        [Range( 1 , 20 )]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}