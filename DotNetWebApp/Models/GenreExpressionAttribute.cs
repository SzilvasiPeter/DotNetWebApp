using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace DotNetWebApp.Models
{
    public class GenreExpressionAttribute : ValidationAttribute, IClientModelValidator
    {
        private string _genre;

        public GenreExpressionAttribute(string genre)
        {
            _genre = genre;
        }

        public void AddValidation(ClientModelValidationContext context)
        {
            throw new NotImplementedException();
        }
    }
}