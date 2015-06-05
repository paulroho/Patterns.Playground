using System;

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
            var factory = new PizzaBaker(incredientProvider);

            var pizzaTomato = factory.CreateTomatoPizza();
            return pizzaTomato;
        }

        private static IIngredientProvider GetIngredientProvider(string supplier)
        {
            throw new NotImplementedException();
        }
    }
}
