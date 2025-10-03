using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.40 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", Mocha";
    }
}