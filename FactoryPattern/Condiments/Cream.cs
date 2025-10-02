using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Cream : CondimentDecorator
{
    public Cream(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.20 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Cream";
    }
}