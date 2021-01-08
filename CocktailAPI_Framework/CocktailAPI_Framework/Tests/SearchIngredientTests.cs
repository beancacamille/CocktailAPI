using System;
using System.Threading;
using NUnit.Framework;

namespace CocktailAPI_Framework
{
    public class SearchIngredientTests
    {
		private SIService _searchIngredient = new SIService();

        [Test]
        public void IngredientCheck()
        {
            Assert.That(_searchIngredient.IngredientSearch("gin"), Is.EqualTo(1));
        }


        [Test]
		public void NumberOfIngredient()
		{
			Assert.That(_searchIngredient.IngredientCount(), Is.EqualTo(100));
		}


    }
}