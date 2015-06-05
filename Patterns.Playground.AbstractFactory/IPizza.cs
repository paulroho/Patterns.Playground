using System.Collections.Generic;
using Patterns.Playground.AbstractFactory.Ingredients;

namespace Patterns.Playground.AbstractFactory
{
    internal interface IPizza
    {
        IEnumerable<IIngredient> Ingredients { get; }
    }
}