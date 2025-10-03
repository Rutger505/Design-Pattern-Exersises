using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class Honey : CondimentDecorator
{
    public Honey(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.30 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", Honey";
    }
}