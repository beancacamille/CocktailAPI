using System;
using System.Configuration;

namespace CocktailAPI_Framework
{
    public static class CocktailConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
