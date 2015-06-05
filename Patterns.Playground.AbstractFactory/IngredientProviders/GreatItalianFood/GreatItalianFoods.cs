using Patterns.Playground.AbstractFactory.IngredientProviders.GreatItalianFood.Ingredienti;
using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory.IngredientProviders.GreatItalianFood
{
    internal class GreatItalianFoods : IIngredientProvider
    {
        public IPizzaFoundation GetPizzaFoundation()
        {
            return new PastaPerPizzaSuperiore();
        }

        public IIngredient GetTomatoTopping()
        {
            return new PomodoroSpeziale();
        }

        public IIngredient GetOreganoTopping()
        {
            return new Oregano();
        }
    }
}
