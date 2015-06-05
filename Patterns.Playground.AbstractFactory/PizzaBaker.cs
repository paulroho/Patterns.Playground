using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory
{
    internal class PizzaBaker
    {
        public IPizza CreateTomatoPizza(IIngredientProvider ingredientProvider)
        {
            var pizza = new Pizza();

            pizza.ApplyPizzaFoundation(ingredientProvider.GetPizzaFoundation());
            pizza.ApplyTopping(ingredientProvider.GetTomatoTopping());
            pizza.ApplyTopping(ingredientProvider.GetOreganoTopping());

            return pizza;
        }
    }
}