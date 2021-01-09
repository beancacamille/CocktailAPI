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

        [Test]
        public void IfInputIsCocktail_AllResultsMustContainInput()
        {
            _searchCocktail = new SCService("margarita");
            Assert.That(_searchCocktail.CheckAllCocktailsContainSearchInput());
        }

        [Test]
        public void IfInputIsNotACocktail_ResultMustBeNull()
        {
            _searchCocktail = new SCService("notcocktail");
            Assert.That(_searchCocktail.GetResult(), Is.Null);
        }
    }
}
