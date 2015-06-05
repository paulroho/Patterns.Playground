using System;
using Patterns.Playground.AbstractFactory.Ingredients;
using Patterns.Playground.AbstractFactory.Nutrition;

namespace Patterns.Playground.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var supplier = args[0];

            var pizzaTomato = MakeMeAPizzaTomato(supplier);

            var caloryCalculator = new CaloryCalculator();
            var calories = caloryCalculator.Calculate(pizzaTomato);

            Console.WriteLine(pizzaTomato);
            Console.WriteLine("It has {0} calories", calories);
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