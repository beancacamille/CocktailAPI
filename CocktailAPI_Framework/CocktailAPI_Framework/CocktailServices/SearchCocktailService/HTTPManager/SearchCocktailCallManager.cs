using System;
using RestSharp;

namespace CocktailAPI_Framework
{
    public class SearchCocktailCallManager
    {
        private readonly RestClient _client;

        public SearchCocktailCallManager()
        {
            _client = new RestClient(CocktailConfigReader.BaseUrl);
        }

        public string SearchCocktailByName(string cocktail)
        {
            var request = new RestRequest("search.php?s=" + cocktail);
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
