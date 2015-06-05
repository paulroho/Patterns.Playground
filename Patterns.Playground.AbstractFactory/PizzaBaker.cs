using System;

namespace Patterns.Playground.AbstractFactory
{
    internal class PizzaBaker
    {
        private readonly IIngredientProvider _ingredientProvider;

        public PizzaBaker(IIngredientProvider ingredientProvider)
        {
            _ingredientProvider = ingredientProvider;
            throw new NotImplementedException();
        }

        public IPizza CreateTomatoPizza()
        {
            throw new NotImplementedException();
        }
    }
}