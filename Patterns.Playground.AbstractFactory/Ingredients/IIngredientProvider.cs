namespace Patterns.Playground.AbstractFactory.Ingredients
{
    internal interface IIngredientProvider
    {
        IPizzaFoundation GetPizzaFoundation();
        IIngredient GetTomatoTopping();
        IIngredient GetOreganoTopping();
    }
}