using FactoryPattern.Beverages;

namespace FactoryPattern.Condiments;

internal class IceCream : CondimentDecorator
{
    public IceCream(Beverage beverage)
    {
        BaseBeverage = beverage;
    }

    public override double Cost()
    {
        return 0.75 + BaseBeverage.Cost();
    }

    public override string GetDescription()
    {
        return BaseBeverage.GetDescription() + ", IceCream";
    }
}