using System;

namespace Patterns.Playground.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var supplier = args[0];

            var incredientProvider = GetIncredientProvider(supplier);
            var factory = new PizzaBaker(incredientProvider);

            var pizzaTomato = factory.CreateTomatoPizza();

            foreach (var incredient in pizzaTomato.Incredients)
            {
                Console.WriteLine(incredient);
            }
        }
    }
}
