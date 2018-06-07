using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Domain
{
    public class Movie
    {
        private const string REGEX = @"^[A-Z]+[a-zA-Z""'\s-]*$";

        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 2)]
        public string Title { get; set; }
        
        [DataType(DataType.Date)]
        [DisplayName("Release Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(REGEX)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")] //data annotation is required so Entity Framework Core can correctly map Price to currency in the database.
        public decimal Price { get; set; }
        
        [Required]
        [StringLength(5)]
        [RegularExpression(REGEX)]
        public string Rating { get; set; }
    }
}
