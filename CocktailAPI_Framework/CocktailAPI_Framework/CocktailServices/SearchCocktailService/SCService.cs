using Newtonsoft.Json.Linq;
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
    }
}
