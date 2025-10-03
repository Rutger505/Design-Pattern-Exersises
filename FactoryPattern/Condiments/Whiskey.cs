using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Whiskey : CondimentDecorator
{
    public Whiskey(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.60 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", Whiskey";
    }
}