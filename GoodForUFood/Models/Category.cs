
using System;
using System.ComponentModel.DataAnnotations;

namespace GoodForUFood.Models
{
	public class Category
	{
        [Required]
        public int CategoryId { get; set; }

        public string CategoryName { get; set; } = string.Empty;

        public string? CategoryDescription { get; set; }

        public List<FoodItem>? FoodItems { get; set; }
    }
}

