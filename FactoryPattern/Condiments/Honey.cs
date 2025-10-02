using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Honey : CondimentDecorator
{
    public Honey(Beverage beverage)
    {
        baseBeverage = beverage;
    }

    public override double cost()
    {
        return 0.30 + baseBeverage.cost();
    }

    public override string GetDescription()
    {
        return baseBeverage.GetDescription() + ", Honey";
    }
}