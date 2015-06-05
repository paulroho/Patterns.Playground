using System.Collections.Generic;
using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory
{
    internal class Pizza : IPizza
    {
        private readonly IPizzaFoundation _pizzaFoundation;
        private readonly List<IIngredient> _ingredients;

        public Pizza(IPizzaFoundation pizzaFoundation)
        {
            _ingredients = new List<IIngredient>();
            _pizzaFoundation = pizzaFoundation;
        }

        public IEnumerable<IIngredient> Ingredients
        {
            get { return _ingredients; }
        }

        public IPizzaFoundation PizzaFoundation
        {
            get { return _pizzaFoundation; }
        }

        public void ApplyTopping(IIngredient ingredient)
        {
            _ingredients.Add(ingredient);
        }
    }
}