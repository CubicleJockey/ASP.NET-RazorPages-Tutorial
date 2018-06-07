using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        //data annotation is required so Entity Framework Core can correctly map Price to currency in the database.
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
