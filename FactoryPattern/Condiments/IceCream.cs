using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class IceCream : CondimentDecorator
{
    public IceCream(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.50 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Ice Cream";
    }
}