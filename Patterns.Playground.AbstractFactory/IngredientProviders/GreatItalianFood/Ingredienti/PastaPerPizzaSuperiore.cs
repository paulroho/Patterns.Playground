using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory.IngredientProviders.GreatItalianFood.Ingredienti
{
    internal class PastaPerPizzaSuperiore : IIngredient, IPizzaFoundation
    {
        public override string ToString()
        {
            return "Pasta per pizza superiore";
        }

        public double Calories { get { return 56.0; } }
    }
}