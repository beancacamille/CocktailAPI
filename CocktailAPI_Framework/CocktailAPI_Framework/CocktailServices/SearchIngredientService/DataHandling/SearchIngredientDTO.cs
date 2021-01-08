using Newtonsoft.Json;

namespace CocktailAPI_Framework
{
    public class SearchIngredientDTO
    {

        public IngredientRoot DrinksList { get; set; }

        public void DeserializeRates(string drinksResponse)
        {
            DrinksList = JsonConvert.DeserializeObject <IngredientRoot>(drinksResponse);
        }



    }
}
