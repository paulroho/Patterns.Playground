namespace Patterns.Playground.AbstractFactory.Ingredients
{
    public class AustrianBasicIngredientProvider : IIngredientProvider
    {
        public IIngredient GetPizzaFoundation()
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

    public class AustrianBasicPizzaboden : IIngredient
    {
        public override string ToString()
        {
            return "Mehlige Pizzabodenpampe";
        }
    }
}