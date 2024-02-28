﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FIHS.Models.Disease
{
    public class Disease
    {
        public int Id { get; set; }
        [MinLength(2), MaxLength(50)]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [MinLength(2), MaxLength(128)]
        public string Description { get; set; }
        [MinLength(2), MaxLength(128)]
        public string Treatments { get; set; }
        [MinLength(2), MaxLength(128)]
        public string Symptoms { get; set; }
        [MinLength(2), MaxLength(128)]
        public string PreventionMethods { get; set; }
        [JsonIgnore,ValidateNever,NotMapped]
        public string Message { get; set; }
    }
}