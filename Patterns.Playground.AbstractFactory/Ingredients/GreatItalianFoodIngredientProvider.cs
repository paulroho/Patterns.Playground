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
    }

    internal class GreatItalianTomato : IIngredient
    {
        public override string ToString()
        {
            return "Great Italian Tomato";
        }
    }

    internal class GreatItalianPizzaFoundation : IIngredient, IPizzaFoundation
    {
        public override string ToString()
        {
            return "Great Italian Pizza Foundation";
        }
    }
}