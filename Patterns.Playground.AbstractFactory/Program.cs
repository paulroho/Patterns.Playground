using System;
using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var supplier = args[0];

            var pizzaTomato = MakeMeAPizzaTomato(supplier);

            foreach (var ingredient in pizzaTomato.Ingredients)
            {
                Console.WriteLine(ingredient);
            }
        }

        private static IPizza MakeMeAPizzaTomato(string supplier)
        {
            var incredientProvider = GetIngredientProvider(supplier);
            var baker = new PizzaBaker();

            return baker.CreateTomatoPizza(incredientProvider);
        }

        private static IIngredientProvider GetIngredientProvider(string supplier)
        {
            return new IngredientProviderRepository().GetIngredientProvider(supplier);
        }
    }
}