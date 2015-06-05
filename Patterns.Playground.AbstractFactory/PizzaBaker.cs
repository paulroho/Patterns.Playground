using System;

namespace Patterns.Playground.AbstractFactory
{
    internal class PizzaBaker
    {
        private readonly IIncredientProvider _incredientProvider;

        public PizzaBaker(IIncredientProvider incredientProvider)
        {
            _incredientProvider = incredientProvider;
            throw new NotImplementedException();
        }

        public IPizza CreateTomatoPizza()
        {
            throw new NotImplementedException();
        }
    }
}