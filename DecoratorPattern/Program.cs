using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, Beverage> beverages = new()
        {
            ["espresso"] = new Espresso(),
            ["lungo"] = new Water(new Espresso()),
            ["americano"] = new Water(new Water(new Espresso()))
        };

        foreach (var kvp in beverages)
        {
            PrintBeverage(kvp.Key, kvp.Value);
        }
    }

    private static void PrintBeverage(string key, Beverage beverage)

    {
        Console.WriteLine($"{key}: {beverage.GetDescription()} ${beverage.cost():#.##}");
    }
}