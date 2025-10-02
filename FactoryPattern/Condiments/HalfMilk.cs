using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class HalfMilk : CondimentDecorator
{
    public HalfMilk(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.15 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Half Milk";
    }
}
