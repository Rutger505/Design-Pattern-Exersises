using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class SteamedMilk : CondimentDecorator
{
    public SteamedMilk(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.35 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", SteamedMilk";
    }
}