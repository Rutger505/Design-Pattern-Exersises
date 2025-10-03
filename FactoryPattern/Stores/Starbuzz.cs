using FactoryPattern.Beverages;
using FactoryPattern.Condiments;

namespace FactoryPattern.Stores;

internal class Starbuzz : IBeverageStore
{
    public Beverage CreateBeverage(BeverageType type)
    {
        return type switch
        {
            BeverageType.Espresso => new Espresso(),
            BeverageType.Doppio => new Espresso(new Espresso()),
            BeverageType.Lungo => new Water(new Espresso()),
            BeverageType.Macchiato => new MilkFoam(new Espresso()),
            BeverageType.Corretta => new Liquor(new Espresso()),
            BeverageType.ConPanna => new Whip(new Espresso()),
            BeverageType.Cappuccino => new MilkFoam(new SteamedMilk(new Espresso())),
            BeverageType.Americano => new Water(new Water(new Espresso())),
            BeverageType.CaffeLatte => new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso()))),
            BeverageType.FlatWhite => new SteamedMilk(new SteamedMilk(new Espresso())),
            BeverageType.Romana => new Lemon(new Espresso()),
            BeverageType.Morocchino => new MilkFoam(new Chocolate(new Espresso())),
            BeverageType.Mocha => new Whip(new SteamedMilk(new Chocolate(new Espresso()))),
            BeverageType.Bicerin => new Whip(new WhiteChocolate(new BlackChocolate(new Espresso()))),
            BeverageType.Breve => new HalfMilk(new MilkFoam(new Espresso())),
            BeverageType.RafCoffee => new Cream(new VanillaSugar(new Espresso())),
            BeverageType.MeadRaf => new Cream(new Honey(new Espresso())),
            BeverageType.Galao => new MilkFoam(new MilkFoam(new Espresso())),
            BeverageType.CaffeAffogato => new IceCream(new Espresso(new Espresso())),
            BeverageType.ViennaCoffee => new Whip(new Whip(new Espresso(new Espresso()))),
            BeverageType.Glace => new IceCream(new Espresso()),
            BeverageType.ChocolateMilk => new Milk(new Milk(new Chocolate())),
            BeverageType.DemiCreme => new Cream(new Cream(new Espresso(new Espresso()))),
            BeverageType.LatteMacchiato => new MilkFoam(new SteamedMilk(new SteamedMilk(new Espresso()))),
            BeverageType.Freddo => new Ice(new Liquor(new Espresso())),
            BeverageType.Frappuccino => new Whip(new SteamedMilk(new Ice(new Espresso()))),
            BeverageType.CaramelFrappuccino => new Syrup(new Cream(new SteamedMilk(new Ice(new Espresso())))),
            BeverageType.Frappe => new IceCream(new SteamedMilk(new SteamedMilk(new Espresso()))),
            BeverageType.IrishCoffee => new Whip(new Whiskey(new Espresso(new Espresso()))),
            _ => throw new ArgumentException($"Unknown beverage type: {type}")
        };
    }
}