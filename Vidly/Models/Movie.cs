using System;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }
    }
}