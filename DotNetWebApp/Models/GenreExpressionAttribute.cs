using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DotNetWebApp.Models
{
    public class GenreExpressionAttribute : ValidationAttribute//, IClientModelValidator
    {
        public GenreExpressionAttribute()
        {
        }

        // public void AddValidation(ClientModelValidationContext validationontext)
        // {
        //     throw new NotImplementedException();
        // }

        // protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        // {
        //     Movie movie = (Movie) validationContext.ObjectInstance;

        //     Genre genreValue;
        //     var isValid = Enum.TryParse(movie.Genre, false, out genreValue);
        //     if(!isValid)
        //     {
        //         // yield return new ValidationResult($"Not valid Genre type: {Genre}", new[] {"Movie.Genre"});
        //         return new ValidationResult(GetErrorMessage());
        //         // if(!(Enum.IsDefined(typeof(Genre), genreValue) | genreValue.ToString().Contains(",")))
        //         // {
        //         //     yield return new ValidationResult($"Not valid Genre type: {Genre}", new[] {"Movie.Genre"});
        //         // }
        //     }else
        //     {
        //         Enum.TryParse(movie.Genre, false, out genreValue);
        //         return ValidationResult.Success;
        //     }
        // }

        // private String GetErrorMessage()
        // {
        //     return $"Not valid Genre type.";
        // }
    }
}