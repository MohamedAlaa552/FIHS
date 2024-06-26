﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FIHS.Models.PlantModels
{
    [Index(nameof(Name), IsUnique = true)]
    public class PlantType
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required,MaxLength(100)]
        public string HeightRange { get; set; }
        [Required, MaxLength(100)]
        public string SpreadRange { get; set; }
        [Required, MaxLength(100)]
        public string LifeCycle { get; set; }
        public string ImgURL { get; set; }
        [ValidateNever,JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public ICollection<PlantsTypesOfPlant> Plants { get; set; }
    }
}
