using System;
using System.Threading;
using NUnit.Framework;

namespace CocktailAPI_Framework
{
    public class SearchIngredientTests
    {
		private SIService _searchIngredient = new SIService();

        [Test]
        public void IfInputIsIngredient_CountIsEqualTo1()
        {
            Assert.That(_searchIngredient.CountIngredientSearched("gin"), Is.EqualTo(1));
        }

        [Test]
        public void IfInputIsNotIngredient_CountIsEqualTo0()
        {
            Assert.That(_searchIngredient.CountIngredientSearched("notdrink"), Is.EqualTo(0));
        }

        [Test]
		public void CheckNumberOfIngredients()
		{
			Assert.That(_searchIngredient.CountAllIngredients(), Is.EqualTo(100));
		}

        [Test]
        public void SearchedIngredientIsCorrect()
        {
            Assert.That(_searchIngredient.GetIngredientSearched("gin"), Does.Contain("gin").IgnoreCase);
        }

        [Test]
        public void IfInputIsNotAnIngredient_ResultMustBeEmpty()
        {
            Assert.That(_searchIngredient.GetIngredientSearched("notdrink"), Is.Empty);
        }
    }
}