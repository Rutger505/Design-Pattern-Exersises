using DecoratorPattern.Beverages;

namespace DecoratorPattern.Condiments;

internal class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.20 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Mocha";
    }
}