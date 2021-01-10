using System;
using RestSharp;

namespace CocktailAPI_Framework
{
    public class SearchIngredientCallManager
    {
        private readonly IRestClient _client;

        public SearchIngredientCallManager()
        {
            _client = new RestClient(CocktailConfigReader.BaseUrl);
        }

        public string GetAllIngredients()
        {
            var request = new RestRequest("list.php?i=list");
            var response = _client.Execute(request, Method.GET);
            return response.Content;
        }

    }
}
