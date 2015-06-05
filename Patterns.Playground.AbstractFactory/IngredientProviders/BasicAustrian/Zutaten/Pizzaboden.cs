using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory.IngredientProviders.BasicAustrian.Zutaten
{
    public class Pizzaboden : IPizzaFoundation
    {
        public override string ToString()
        {
            return "Mehlige Pizzabodenpampe";
        }

        public double Calories
        {
            get { return 234.0; }
        }
    }
}