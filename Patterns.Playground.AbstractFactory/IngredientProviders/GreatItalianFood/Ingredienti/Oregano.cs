using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory.IngredientProviders.GreatItalianFood.Ingredienti
{
    internal class Oregano : IIngredient
    {
        public override string ToString()
        {
            return "Oregano italiana";
        }

        public double Calories { get { return 345.0; } }
    }
}