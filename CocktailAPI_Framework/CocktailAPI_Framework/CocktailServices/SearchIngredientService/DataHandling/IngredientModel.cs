namespace CocktailAPI_Framework
{

    public class IngredientRoot
    {
        public DrinkIngredients[] IngredientsForDrinks { get; set; }
    }

    public class DrinkIngredients
    {
        public string strIngredient1 { get; set; }
    }
}
