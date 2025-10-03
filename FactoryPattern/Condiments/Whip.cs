using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Whip : CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.25 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", Whip";
    }
}