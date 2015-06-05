using Patterns.Playground.AbstractFactory.Nutrition;

namespace Patterns.Playground.AbstractFactory.Ingredients
{
    public interface IPizzaFoundation : IHasCalories
    {
    }

    public interface IIngredient : IHasCalories
    {
    }
}