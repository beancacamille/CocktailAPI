using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CocktailAPI_Framework
{
    public class SIService
    {
		//Instance of the call manager that manages the call to the API to get the data
		public SearchIngredientCallManager SearchIngredientCallManager { get; set; } = new SearchIngredientCallManager();

		//Deserialises our call into the format of our specified model
		public SearchIngredientDTO SearchIngredientDTO { get; set; } = new SearchIngredientDTO();

		//the last set of rates retrieved
		public string Ingredients { get; set; }

		public JObject Json_ingredients { get; set; }




        public SIService()
		{
			//The api call is set to the Ingredients property
			Ingredients = SearchIngredientCallManager.GetAllIngredients();
			//Take the live rates and deserialise it to a JObject
			Json_ingredients = JsonConvert.DeserializeObject<JObject>(Ingredients);

			//Another version of the response we get back from the HTTP maanger as a DTO
			SearchIngredientDTO.DeserializeRates(Ingredients);
        }

		public int CountAllIngredients()
		{
			var count = 0;
			foreach (var item in Json_ingredients["drinks"])
			{
				count++;
			}

			return count;
		}

        public int CountIngredientSearched(string liquid)
        {
			var count = 0;
			foreach (var item in Json_ingredients["drinks"])
			{
				if (item.ToString().Contains(liquid))
                {
					count++;
				}
			}
			return count;
			
		}

		public string GetIngredientSearched(string liquid)
		{
			string correctIngredient = "";
			foreach (var item in Json_ingredients["drinks"])
			{
				if (item.ToString().Contains(liquid))
				{
					correctIngredient = item.ToString();
				}
			}
			return correctIngredient;

		}
	}
}
