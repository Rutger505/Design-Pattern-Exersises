using FactoryPattern.Beverages;
using FactoryPattern.Condiments;

namespace FactoryPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Beverage flatWhiteVendi = new IceCream(new Espresso(new Espresso()));
        flatWhiteVendi.Size = Size.VENDI;

        Dictionary<string, Beverage> beverages = new()
        {
            ["Espresso"] = new Espresso(),
            ["Doppio"] = new Espresso(new Espresso()),
            ["Lungo"] = new Water(new Espresso()),
            ["Macchiato"] = new MilkFoam(new Espresso()),
            ["Corretta"] = new Liquor(new Espresso()),
            ["Con Panna"] = new Whip(new Espresso()),
            ["Cappucinno"] = new MilkFoam(new SteamedMilk(new Espresso())),
            ["Americano"] = new Water(new Water(new Espresso())),
            ["Caffé Latte"] = new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso()))),
            ["Flat White"] = new SteamedMilk(new SteamedMilk(new Espresso())),
            ["Flat White Vendi size"] = flatWhiteVendi,
            ["Romana"] = new Lemon(new Espresso()),
            ["Morocchino"] = new MilkFoam(new Chocolate(new Espresso())),
            ["Mocha"] = new Whip(new SteamedMilk(new Chocolate(new Espresso()))),
            ["Bicerin"] = new Whip(new WhiteChocolate(new BlackChocolate(new Espresso()))),
            ["Breve"] = new HalfMilk(new MilkFoam(new Espresso())),
            ["Raf coffee"] = new Cream(new VanillaSugar(new Espresso())),
            ["Mead raf"] = new Cream(new Honey(new Espresso())),
            ["Galao"] = new MilkFoam(new MilkFoam(new Espresso())),
            ["Caffé affogato"] = new IceCream(new Espresso(new Espresso())),
            ["Vienna coffee"] = new Whip(new Whip(new Espresso(new Espresso()))),
            ["Glace"] = new IceCream(new Espresso()),
            ["Chocolate milk"] = new Milk(new Milk(new Chocolate())),
            ["Demi – créme"] = new Cream(new Cream(new Espresso(new Espresso()))),
            ["Latte macchiato"] = new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso()))),
            ["Freddo"] = new Ice(new Liquor(new Espresso())),
            ["Frappuccino"] = new Whip(new SteamedMilk(new Ice(new Espresso()))),
            ["Caramel frappuccino"] =
                new Syrup(new Cream(new SteamedMilk(new Ice(new Espresso())))),
            ["Frappe"] = new IceCream(new SteamedMilk(new SteamedMilk(new Espresso()))),
            ["Irish Coffee"] = new Whip(new Whiskey(new Espresso(new Espresso())))
        };

        foreach (var kvp in beverages) PrintBeverage(kvp.Key, kvp.Value);
    }

    private static void PrintBeverage(string key, Beverage beverage)
    {
        Console.WriteLine($"{key}: {beverage.GetDescription()} ${beverage.CostBySize():#.##}");
    }
}