namespace Patterns.Playground.AbstractFactory.Ingredients
{
    public class AustrianBasicIngredientProvider : IIngredientProvider
    {
        public IPizzaFoundation GetPizzaFoundation()
        {
            return new AustrianBasicPizzaboden();
        }

        public IIngredient GetTomatoTopping()
        {
            return new AustrianBasicParadeiser();
        }

        public IIngredient GetOreganoTopping()
        {
            return new GreatItalianOregano();
        }
    }

    public class AustrianBasicParadeiser : IIngredient
    {
        public override string ToString()
        {
            return "Österreichische Paradeiser";
        }
    }

    public class AustrianBasicPizzaboden : IPizzaFoundation
    {
        public override string ToString()
        {
            return "Mehlige Pizzabodenpampe";
        }
    }
}