using System;
namespace GoodForUFood.Models
{
	public interface IFoodItemRepository
	{
		
		IEnumerable<FoodItem> AllFoodItems { get; }

		IEnumerable<FoodItem> FoodItemOfTheWeek { get; }

		FoodItem? GetFoodItemById(int FoodItemId);
		
	}
}

