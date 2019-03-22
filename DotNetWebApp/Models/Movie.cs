using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetWebApp.Models
{
    public class Movie //: IValidatableObject
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

        //[RegularExpression(@"^[A-Z]*$", ErrorMessage = "Make sure that all letter is upper-case.")]
        // [Required]
        // [StringLength(11)]
        // [GenreExpression]
        // public String Genre { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Range(0,5)]
        [Required]
        public double Rating { get; set; }

        // [NotMapped]
        // public Genre GenreEnum
        // {
        //     get
        //     {
        //         Genre genre;
        //         Enum.TryParse<Genre>(Genre, out genre);
        //         return genre;
        //     }
        // }

        // Class level validation
        // public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        // {
        //     Genre genreValue;
        //     var result = new List<ValidationResult>();
        //     var isValid = Enum.TryParse(Genre, true, out genreValue);
        //     if(!isValid)
        //     {
        //         // yield return new ValidationResult($"Not valid Genre type: {Genre}", new[] {"Movie.Genre"});
        //         result.Add(new ValidationResult("Not valid Genre Name"));
        //         return result;
        //         // if(!(Enum.IsDefined(typeof(Genre), genreValue) | genreValue.ToString().Contains(",")))
        //         // {
        //         //     yield return new ValidationResult($"Not valid Genre type: {Genre}", new[] {"Movie.Genre"});
        //         // }
        //     }else
        //     {
        //         Enum.TryParse(Genre, true, out genreValue);
        //         return result;
        //     }
        // }

        
    }
}