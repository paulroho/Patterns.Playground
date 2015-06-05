namespace Patterns.Playground.AbstractFactory.Ingredients
{
    internal interface IIngredientProvider
    {
        IIngredient GetPizzaFoundation();
        IIngredient GetTomatoTopping();
        IIngredient GetOreganoTopping();
    }
}