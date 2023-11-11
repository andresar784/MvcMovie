using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public enum Genre
    {
        Action,
        Comedy,
        Drama,
        Familiar,
        Other, 
    }
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }

        public string? ImageName { get; set; }
        [NotMapped]
        public string? ImagePath { get; set; }
        //public string ImagePath => !string.IsNullOrEmpty(ImageName) ? $"/images/{ImageName}" : "/images/default.jpg";
    }
}
