using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory.IngredientProviders.GreatItalianFood.Ingredienti
{
    internal class PomodoroSpeziale : IIngredient
    {
        public override string ToString()
        {
            return "Pomodoro italiana speziale";
        }

        public double Calories { get { return 456.0; } }
    }
}