using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory.IngredientProviders.BasicAustrian.Zutaten
{
    public class Paradeiser : IIngredient
    {
        public override string ToString()
        {
            return "Österreichische Paradeiser";
        }

        public double Calories
        {
            get { return 123.0; }
        }
    }
}