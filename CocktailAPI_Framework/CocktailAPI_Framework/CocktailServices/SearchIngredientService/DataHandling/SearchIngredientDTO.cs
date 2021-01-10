using Newtonsoft.Json;

namespace CocktailAPI_Framework
{
    public class SearchIngredientDTO
    {

        public IngredientRoot IngredientsList { get; set; }

        public void DeserializeRates(string ingredientsResponse)
        {
            IngredientsList = JsonConvert.DeserializeObject <IngredientRoot>(ingredientsResponse);
        }



    }
}
