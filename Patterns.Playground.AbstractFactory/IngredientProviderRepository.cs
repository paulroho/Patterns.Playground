using System;
using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory
{
    internal class IngredientProviderRepository
    {
        public IIngredientProvider GetIngredientProvider(string supplier)
        {
            // HACK
            switch (supplier)
            {
                case "GreatItalianFood":
                    return new GreatItalianFoodIngredientProvider();
                case "AustrianBasic":
                    return new AustrianBasicIngredientProvider(); 
                default:
                    throw new ArgumentException(string.Format("Supplier \"{0}\" is not supported.", supplier));
            }
        }
    }
}