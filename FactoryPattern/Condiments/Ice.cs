using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Ice : CondimentDecorator
{
    public Ice(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.05 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Ice";
    }
}
