using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Whiskey : CondimentDecorator
{
    public Whiskey(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.70 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Whiskey";
    }
}