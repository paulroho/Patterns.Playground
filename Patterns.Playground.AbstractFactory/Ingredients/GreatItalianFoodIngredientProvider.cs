namespace Patterns.Playground.AbstractFactory.Ingredients
{
    internal class GreatItalianFoodIngredientProvider : IIngredientProvider
    {
        public IPizzaFoundation GetPizzaFoundation()
        {
            return new GreatItalianPizzaFoundation();
        }

        public IIngredient GetTomatoTopping()
        {
            return new GreatItalianTomato();
        }

        public IIngredient GetOreganoTopping()
        {
            return new GreatItalianOregano();
        }
    }

    internal class GreatItalianOregano : IIngredient
    {
        public override string ToString()
        {
            return "Great Italian Oregano";
        }

        public double Calories { get { return 345.0; } }
    }

    internal class GreatItalianTomato : IIngredient
    {
        public override string ToString()
        {
            return "Great Italian Tomato";
        }

        public double Calories { get { return 456.0; } }
    }

    internal class GreatItalianPizzaFoundation : IIngredient, IPizzaFoundation
    {
        public override string ToString()
        {
            return "Great Italian Pizza Foundation";
        }

        public double Calories { get { return 56.0; } }
    }
}