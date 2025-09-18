using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Syrup : CondimentDecorator
{
    public Syrup(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.25 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Syrup";
    }
}
