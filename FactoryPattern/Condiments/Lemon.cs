using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Lemon : CondimentDecorator
{
    public Lemon(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.30 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Lemon";
    }
}