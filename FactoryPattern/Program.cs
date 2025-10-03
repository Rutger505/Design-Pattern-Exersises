using FactoryPattern.Beverages;
using FactoryPattern.Stores;

namespace FactoryPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        var store = new Starbuzz();

        Beverage flatWhiteVendi = store.CreateBeverage(BeverageType.CaffeAffogato);
        flatWhiteVendi.Size = Size.Vendi;

        Dictionary<string, Beverage> beverages = new()
        {
            ["Espresso"] = store.CreateBeverage(BeverageType.Espresso),
            ["Doppio"] = store.CreateBeverage(BeverageType.Doppio),
            ["Lungo"] = store.CreateBeverage(BeverageType.Lungo),
            ["Macchiato"] = store.CreateBeverage(BeverageType.Macchiato),
            ["Corretta"] = store.CreateBeverage(BeverageType.Corretta),
            ["Con Panna"] = store.CreateBeverage(BeverageType.ConPanna),
            ["Cappucinno"] = store.CreateBeverage(BeverageType.Cappuccino),
            ["Americano"] = store.CreateBeverage(BeverageType.Americano),
            ["Caffé Latte"] = store.CreateBeverage(BeverageType.CaffeLatte),
            ["Flat White"] = store.CreateBeverage(BeverageType.FlatWhite),
            ["Flat White Vendi size"] = flatWhiteVendi,
            ["Romana"] = store.CreateBeverage(BeverageType.Romana),
            ["Morocchino"] = store.CreateBeverage(BeverageType.Morocchino),
            ["Mocha"] = store.CreateBeverage(BeverageType.Mocha),
            ["Bicerin"] = store.CreateBeverage(BeverageType.Bicerin),
            ["Breve"] = store.CreateBeverage(BeverageType.Breve),
            ["Raf coffee"] = store.CreateBeverage(BeverageType.RafCoffee),
            ["Mead raf"] = store.CreateBeverage(BeverageType.MeadRaf),
            ["Galao"] = store.CreateBeverage(BeverageType.Galao),
            ["Caffé affogato"] = store.CreateBeverage(BeverageType.CaffeAffogato),
            ["Vienna coffee"] = store.CreateBeverage(BeverageType.ViennaCoffee),
            ["Glace"] = store.CreateBeverage(BeverageType.Glace),
            ["Chocolate milk"] = store.CreateBeverage(BeverageType.ChocolateMilk),
            ["Demi – créme"] = store.CreateBeverage(BeverageType.DemiCreme),
            ["Latte macchiato"] = store.CreateBeverage(BeverageType.LatteMacchiato),
            ["Freddo"] = store.CreateBeverage(BeverageType.Freddo),
            ["Frappuccino"] = store.CreateBeverage(BeverageType.Frappuccino),
            ["Caramel frappuccino"] = store.CreateBeverage(BeverageType.CaramelFrappuccino),
            ["Frappe"] = store.CreateBeverage(BeverageType.Frappe),
            ["Irish Coffee"] = store.CreateBeverage(BeverageType.IrishCoffee)
        };

        foreach (var kvp in beverages) PrintBeverage(kvp.Key, kvp.Value);
    }

    private static void PrintBeverage(string key, Beverage beverage)
    {
        Console.WriteLine($"{key}: {beverage.GetDescription()} ${beverage.CostBySize():#.##}");
    }
}