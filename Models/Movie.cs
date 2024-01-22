using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieApp.Models
    {
    public class Movie
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        [Required]
        public string? Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$", ErrorMessage = "Ratings must start with an uppercase character and can only contain '-' for special characters.")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }

        [DisplayName("Movie Poster")]
        public string? ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload Movie Poster")]
        public IFormFile? ImageFile { get; set; }
        }
    }
