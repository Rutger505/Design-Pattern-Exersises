using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class SteamedMilk : CondimentDecorator
{
    public SteamedMilk(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.30 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Steamed Milk";
    }
}