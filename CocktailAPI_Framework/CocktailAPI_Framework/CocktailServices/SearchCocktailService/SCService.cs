﻿using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CocktailAPI_Framework
{
    public class SCService
    {
        public SearchCocktailCallManager SearchCocktailCallManager { get; set; } = new SearchCocktailCallManager();
        public SearchCocktailDTO SearchCocktailDTO { get; set; } = new SearchCocktailDTO();
        public string Cocktails { get; set; }
        public JObject JsonCocktails { get; set; }
        public string SearchInput { get; set; }

        public SCService(string searchInput)
        {
            SearchInput = searchInput;
            Cocktails = SearchCocktailCallManager.SearchCocktailByName(SearchInput);
            JsonCocktails = JsonConvert.DeserializeObject<JObject>(Cocktails);

            SearchCocktailDTO.DeserializeCocktails(Cocktails);
        }

        public Drink[] GetResult()
        {
            return SearchCocktailDTO.CocktailRoot.drinks;
        }

        public bool CheckAllCocktailsContainSearchInput()
        {
            foreach (var cocktail in SearchCocktailDTO.CocktailRoot.drinks)
            {
                if (!cocktail.strDrink.ToLower().Contains(SearchInput.ToLower())) return false;
            }
            return true;
        }

        public List<string> GetIngredients()
        {
            var cocktail = JsonCocktails["drinks"][0];
            var ingredients = new List<string>();

            for (int i = 1; i <= 15; i++)
            {
                if (cocktail[$"strIngredient{i}"].ToString() != "")
                {
                    ingredients.Add(cocktail[$"strIngredient{i}"].ToString());
                }
            }

            return ingredients;
        }
    }
}
