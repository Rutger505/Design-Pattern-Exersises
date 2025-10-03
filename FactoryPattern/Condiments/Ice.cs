using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Ice : CondimentDecorator
{
    public Ice(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.05 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", Ice";
    }
}