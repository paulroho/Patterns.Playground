using System.Collections.Generic;
using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory
{
    internal class Pizza : IPizza
    {
        private readonly List<IIngredient> _ingredients;

        public Pizza()
        {
            _ingredients = new List<IIngredient>();
        }

        public IEnumerable<IIngredient> Ingredients
        {
            get { return _ingredients; }
        }

        public void ApplyPizzaFoundation(IIngredient ingredient)
        {
            _ingredients.Add(ingredient);
        }

        public void ApplyTopping(IIngredient ingredient)
        {
            _ingredients.Add(ingredient);
        }
    }
}