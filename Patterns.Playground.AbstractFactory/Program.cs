﻿using System;
using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var supplier = args[0];

            var pizzaTomato = MakeMeAPizzaTomato(supplier);

            Console.WriteLine(pizzaTomato);
        }

        private static IPizza MakeMeAPizzaTomato(string supplier)
        {
            var ingredientProvider = GetIngredientProvider(supplier);
            var baker = new PizzaBaker();

            return baker.CreateTomatoPizza(ingredientProvider);
        }

        private static IIngredientProvider GetIngredientProvider(string supplier)
        {
            return new IngredientProviderRepository().GetIngredientProvider(supplier);
        }
    }
}