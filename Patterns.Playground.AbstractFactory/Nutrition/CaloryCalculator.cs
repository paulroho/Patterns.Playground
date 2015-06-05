using System.Linq;

namespace Patterns.Playground.AbstractFactory.Nutrition
{
    internal class CaloryCalculator
    {
        public double Calculate(IPizza pizza)
        {
            return pizza.PizzaFoundation.Calories +
                   pizza.Ingredients.Sum(i => i.Calories);
        }
    }
}