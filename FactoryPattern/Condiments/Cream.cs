using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Cream : CondimentDecorator
{
    public Cream(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.30 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", Cream";
    }
}