using System;
using NUnit.Framework;

namespace CocktailAPI_Framework
{
    class SearchCocktailTests
    {
        private SCService _searchCocktail;

        [Test]
        public void IfInputIsCocktail_ResultMustBeGreaterThan0()
        {
            _searchCocktail = new SCService("margarita");
            Assert.That(_searchCocktail.GetResult(), Has.Length.GreaterThan(0));
        }
    }
}
