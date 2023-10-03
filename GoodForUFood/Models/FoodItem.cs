using System;
using System.ComponentModel.DataAnnotations;

namespace GoodForUFood.Models
{
    public class FoodItem
    {
        [Required]
        public int FoodItemId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? ShortDescription { get; set; }

        public string? LongDescription { get; set; }

        public string? ImageURL { get; set; }

        public bool IsRecipeOfTheWeek { get; set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public int? Calories { get; set; }
    }
}

