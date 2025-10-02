using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Whip : CondimentDecorator
{
    public Whip(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.10 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Whip";
    }
}