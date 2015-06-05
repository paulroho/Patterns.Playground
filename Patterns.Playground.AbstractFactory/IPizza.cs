using System.Collections.Generic;

namespace Patterns.Playground.AbstractFactory
{
    internal interface IPizza
    {
        IEnumerable<IIncredient> Incredients { get; }
    }
}