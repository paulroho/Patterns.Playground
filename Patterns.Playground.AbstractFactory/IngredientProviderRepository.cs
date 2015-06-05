using System;
using Patterns.Playground.AbstractFactory.IngredientProviders.BasicAustrian;
using Patterns.Playground.AbstractFactory.IngredientProviders.GreatItalianFood;
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
                    return new GreatItalianFoods();
                case "AustrianBasic":
                    return new AustrianBasicIngredients(); 
                default:
                    throw new ArgumentException(string.Format("Supplier \"{0}\" is not supported.", supplier));
            }
        }
    }
}