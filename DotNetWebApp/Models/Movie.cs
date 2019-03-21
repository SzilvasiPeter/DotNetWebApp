using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetWebApp.Models
{
    public class Movie : IValidatableObject
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$", ErrorMessage = "Genre has to be start with upper-case letter")]
        [Required]
        [StringLength(11)]
        //[GenreExpression]
        public String Genre { get; set; }

        [Range(0,5)]
        [Required]
        public double Rating { get; set; }

        [NotMapped]
        public Genre GenreEnum
        {
            get
            {
                Genre genre;
                Enum.TryParse<Genre>(Genre, out genre);
                return genre;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            Genre genreValue;
            if(Enum.TryParse(Genre, true, out genreValue))
            {
                if(!(Enum.IsDefined(typeof(Genre), genreValue) | genreValue.ToString().Contains(",")))
                {
                    yield return new ValidationResult($"Not valid Genre type: {Genre}", new[] {"Movie.Genre"});
                }
            }else
            {
                yield return new ValidationResult($"Not valid Genre type: {Genre}", new[] {"Movie.Genre"});
            }

        }

        
    }
}