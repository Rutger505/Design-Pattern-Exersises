using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class WhiteChocolate : CondimentDecorator
{
    public WhiteChocolate(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.35 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", White chocolate";
    }
}
