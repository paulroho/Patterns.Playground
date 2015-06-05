using Patterns.Playground.AbstractFactory.IngredientProviders.BasicAustrian.Zutaten;
using Patterns.Playground.AbstractFactory.IngredientProviders.GreatItalianFood.Ingredienti;
using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory.IngredientProviders.BasicAustrian
{
    public class AustrianBasicIngredients : IIngredientProvider
    {
        public IPizzaFoundation GetPizzaFoundation()
        {
            return new Pizzaboden();
        }

        public IIngredient GetTomatoTopping()
        {
            return new Paradeiser();
        }

        public IIngredient GetOreganoTopping()
        {
            return new Oregano();
        }
    }
}
