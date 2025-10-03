using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class HalfMilk : CondimentDecorator
{
    public HalfMilk(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.50 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", HalfMilk";
    }
}