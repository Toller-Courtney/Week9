using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60,MinimumLength=3)]
        [RegularExpression("^[a-zA-Z0-9 '-]*$")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName="decimal(18,2)")]
       
        public decimal Price { get; set; }
        
        public string Rating { get; set; }
        [Display(Name="Imdb ID#")]
        public string ImdbID { get; set; }
    }
}