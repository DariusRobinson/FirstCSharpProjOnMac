using System;
using Microsoft.EntityFrameworkCore;

namespace GoodForUFood.Models
{
	public class GoodFoodContext : DbContext 
	{
		public GoodFoodContext(DbContextOptions<GoodFoodContext>options) : base(options)
		{
		}

		public DbSet<FoodItem> FoodItems { get; set; }

		public DbSet<Category> Categories { get; set; }
	}
}

