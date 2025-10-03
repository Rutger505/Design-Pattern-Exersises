using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Milk : CondimentDecorator
{
    public Milk(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.20 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", Milk";
    }
}