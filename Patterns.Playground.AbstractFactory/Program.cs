using System;

namespace Patterns.Playground.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var supplier = args[0];

            var pizzaTomato = MakeMeAPizzaTomato(supplier);

            foreach (var incredient in pizzaTomato.Incredients)
            {
                Console.WriteLine(incredient);
            }
        }

        private static IPizza MakeMeAPizzaTomato(string supplier)
        {
            var incredientProvider = GetIncredientProvider(supplier);
            var factory = new PizzaBaker(incredientProvider);

            var pizzaTomato = factory.CreateTomatoPizza();
            return pizzaTomato;
        }

        private static IIncredientProvider GetIncredientProvider(string supplier)
        {
            throw new NotImplementedException();
        }
    }
}
