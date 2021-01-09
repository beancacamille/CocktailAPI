using System;
using Newtonsoft.Json;

namespace CocktailAPI_Framework
{
    public class SearchCocktailDTO
    {
        public CocktailRoot CocktailRoot { get; set; }

        public void DeserializeCocktails(string searchCocktailResponse)
        {
            CocktailRoot = JsonConvert.DeserializeObject<CocktailRoot>(searchCocktailResponse);
        }
    }
}
